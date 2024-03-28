using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using Org.BouncyCastle.Crypto.Macs;
using Reviewer.Models;
using Reviewer.Models.Data;
using Reviewer.ViewModel;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Reviewer.Controllers
{
    public class AccountController : Controller
    {
        private readonly ReviewSPContext db;

        public AccountController(ReviewSPContext db)
        {
            this.db = db;
        }

        [HttpGet, AllowAnonymous]
        public IActionResult DangNhap()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public IActionResult DangNhap(LoginViewModel loginModel)
        {
            KhachHang kh = db.KhachHang.SingleOrDefault(p => p.UsernameKh
           == loginModel.UserName && p.PassKh == MaHoa.ToMD5(loginModel.Password));
            Author au = db.Author.SingleOrDefault(a => a.UsernameRe
          == loginModel.UserName && a.PasswordRe == MaHoa.ToMD5(loginModel.Password));
            if (kh == null && au == null)//không khớp
            {
                ViewBag.ThongBaoLoi = "Sai thông tin đăng nhập";
                return View();
            }
            HttpContext.Session.Set("KH", kh);
            HttpContext.Session.Set("AU", au);
            return RedirectToAction("Index", "Home");//default
        }

        [Route("get-captcha-image")]
        public IActionResult GetCaptchaImage()
        {
            int width = 100;
            int height = 36;
            var captchaCode = Captcha.GenerateCaptchaCode();
            var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

        public IActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DangKy(IFormFile Avatar, IFormCollection collection, KhachHang kh, CaptchaResult captcha)
        {
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            string passwordMD5 = MaHoa.ToMD5(matkhau);
            var nhaplaimatkhau = collection["Nhaplai"];
            var hoten = collection["hotenkh"];
            //var diachi = collection["Diachi"];
            var email = collection["email"];
            if (ModelState.IsValid)
            {
                if (!Captcha.ValidateCaptchaCode(captcha.CaptchaCode, HttpContext))
                {
                    ViewData["LoiCaptcha"] = "Captcha không đúng";
                    return View("DangKy");
                }
            }
            var b = db.KhachHang.SingleOrDefault(u => u.UsernameKh == tendn);
            if (b != null)
            {
                ViewData["LoiUser"] = "Username đã tồn tại";
                return View("DangKy");
            }
            var c = db.KhachHang.SingleOrDefault(e => e.EmailKh == email);
            if (c != null)
            {
                ViewData["LoiEmail"] = "Email đã tồn tại";
                return View("DangKy");
            }
            kh.HoTenKh = hoten;
            kh.UsernameKh = tendn;
            kh.PassKh = passwordMD5;
            kh.EmailKh = email;
            db.KhachHang.Add(kh);
            db.SaveChanges();
            if (Avatar == null || Avatar.Length == 0)
                return Content("file not selected");
            {
                string fileName = kh.MaKh + Path.GetExtension(Avatar.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Customer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await Avatar.CopyToAsync(stream);
                }
                kh.AvatarKh = fileName;
            }
            db.Entry(kh).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Đăng Ký Thành Viên", "nguyenhuuminhluan@gmail.com"));
            message.To.Add(new MailboxAddress("Đăng Ký Thành Viên", "nhomlbttek@gmail.com"));
            message.To.Add(new MailboxAddress("Đăng Ký Thành Viên", email));
            message.Subject = "Đăng ký thành công (LBT Tek)";
            message.Body = new TextPart("html")
            {
                Text = "<b>Tên đăng nhập: </b>" + tendn + "<br/>" + "<b>Mật khẩu: </b>" + matkhau + "<br/>" + "<b>Email đăng ký: </b>" + email
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("nguyenhuuminhluan@gmail.com", "crbzibxcinjmamwm");
                client.Send(message);

                client.Disconnect(true);
            }

            return RedirectToAction("DangNhap", "Account");
        }

        public IActionResult DangKyAu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DangKyAu(IFormFile AvatarRe, IFormCollection collection, Author au, CaptchaResult captcha)
        {
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            string passwordMD5 = MaHoa.ToMD5(matkhau);
            var nhaplaimatkhau = collection["Nhaplai"];
            var hoten = collection["hotenkh"];
            var diachi = collection["Diachi"];
            var email = collection["email"];
            if (ModelState.IsValid)
            {
                if (!Captcha.ValidateCaptchaCode(captcha.CaptchaCode, HttpContext))
                {
                    ViewData["LoiCaptcha"] = "Captcha không đúng";
                    return View("DangKyAu");
                }
            }
            var b = db.Author.SingleOrDefault(u => u.UsernameRe == tendn);
            if (b != null)
            {
                ViewData["LoiUserRe"] = "Username đã tồn tại";
                return View("DangKyAu");
            }
            var c = db.Author.SingleOrDefault(e => e.EmailRe == email);
            if (c != null)
            {
                ViewData["LoiEmailRe"] = "Email đã tồn tại";
                return View("DangKyAu");
            }
            au.FullnameRe = hoten;
            au.UsernameRe = tendn;
            au.PasswordRe = passwordMD5;
            au.EmailRe = email;
            au.DiaChiRe = diachi;
            au.SoTien = 0;
            db.Author.Add(au);
            db.SaveChanges();
            if (AvatarRe == null || AvatarRe.Length == 0)
                return Content("file not selected");
            {
                string fileName = au.MaReviewer + Path.GetExtension(AvatarRe.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Reviewer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await AvatarRe.CopyToAsync(stream);
                }
                au.AvatarRe = fileName;
            }
            db.Entry(au).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Đăng Ký Thành Viên", "nguyenhuuminhluan@gmail.com"));
            message.To.Add(new MailboxAddress("Đăng Ký Thành Viên", "nhomlbttek@gmail.com"));
            message.To.Add(new MailboxAddress("Đăng Ký Thành Viên", email));
            message.Subject = "Đăng ký Reviewer thành công";
            message.Body = new TextPart("html")
            {
                Text = "<b>Tên đăng nhập: </b>" + tendn + "<br/>" + "<b>Mật khẩu: </b>" + matkhau + "<br/>" + "<b>Email đăng ký: </b>" + email + "<br/>" + "<b>Địa chỉ: </b>" + diachi + "<br/>" + "<b>Mã thành viên của bạn là: </b>" + au.MaReviewer
                        + "<br/>" + "Bạn muốn viết bài vui lòng gửi file word . Trong file word nhớ ghi: " + "<b>Họ tên, email và mã thành viên </b>" + "của bạn."
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("nguyenhuuminhluan@gmail.com", "crbzibxcinjmamwm");
                client.Send(message);

                client.Disconnect(true);
            }
            return RedirectToAction("DangNhap", "Account");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("KH");
            HttpContext.Session.Remove("AU");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult CheckUsername(string Name)
        {
            bool isValid = db.KhachHang.ToList().Exists(p => p.UsernameKh.Equals(Name, StringComparison.CurrentCultureIgnoreCase));
            return Json(isValid);
        }

        //kiem tra email ton tai
        [HttpPost]
        public IActionResult CheckEmail(string email)
        {
            bool isValid = db.KhachHang.ToList().Exists(p => p.EmailKh.Equals(email, StringComparison.CurrentCultureIgnoreCase));
            return Json(isValid);
        }

        public IActionResult Subcribe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subcribe(IFormCollection collection, Subcribe sub)
        {
            var mail = collection["mail"];
            sub.EmailSub = mail;
            db.Subcribe.Add(sub);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AboutKH()
        {
            if (HttpContext.Session.Get("KH") == null)
            {
                return RedirectToAction("Index");
            }

            if (HttpContext.Session.Get("AU") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult SuaMK(int? id)
        {
            Author ad = db.Author.Find(id);
            return View(ad);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaMK(Author admin, LoginViewModel loginModel, IFormCollection collection)
        {
            Author au = db.Author.SingleOrDefault(a => a.PasswordRe == MaHoa.ToMD5(loginModel.Password) && a.MaReviewer == a.MaReviewer);
            if (au == null)//không khớp
            {
                ViewBag.ThongBaoLoi = "Mật khẩu cũ không chính xác";
                return View();
            }
            Author ad = db.Author.SingleOrDefault(n => n.MaReviewer == admin.MaReviewer);
            ad.FullnameRe = admin.FullnameRe;
            ad.PasswordRe = MaHoa.ToMD5(admin.PasswordRe);
            ad.EmailRe = admin.EmailRe;
            db.Entry(ad).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("Index", "Home");
        }

        public IActionResult QuenMK()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult QuenMK(IFormCollection collection, PassForgotViewModel mail, Author kt)
        {
            Author au = db.Author.SingleOrDefault(a => a.EmailRe == mail.Email);
            var email = collection["Email"];
            if (au == null)//không khớp
            {
                ViewBag.ThongBaoLoi = "Email không tồn tại";
                return View();
            }
            Random rd = new Random();
            string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
            StringBuilder mann = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                mann.Append(pattern[rd.Next(0, pattern.Length)]);
            }
            var result = db.Author.SingleOrDefault(b => b.EmailRe == mail.Email);
            if (result != null)
            {
                result.PasswordRe = MaHoa.ToMD5(mann.ToString());
                db.SaveChanges();
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Quên Mật Khẩu", "nguyenhuuminhluan@gmail.com"));
                message.To.Add(new MailboxAddress("Quên Mật Khẩu", "nhomlbttek@gmail.com"));
                message.To.Add(new MailboxAddress("Reset Password", email));
                message.Subject = "Reset Password Thành Công";
                message.Body = new TextPart("html")
                {
                    Text = "<b>Email đăng ký: </b>" + email + "<br/>" + "<b>Mật khẩu mới của bạn: </b>" + mann.ToString()
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("nguyenhuuminhluan@gmail.com", "crbzibxcinjmamwm");
                    client.Send(message);

                    client.Disconnect(true);
                }
                return RedirectToAction("DangNhap", "Account");
            }
            return View();
        }

        public IActionResult RutTien()
        {
            if (HttpContext.Session.Get("AU") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult RutTien(IFormCollection collection, Pay pay, Author author, CaptchaResult captcha)
        {
            var emailNL = collection["EmailNl"];
            var money = collection["SoTien"];
            var ma = collection["MaReviewer"];
            var email = collection["Email"];
            if (ModelState.IsValid)
            {
                if (!Captcha.ValidateCaptchaCode(captcha.CaptchaCode, HttpContext))
                {
                    ViewData["LoiCaptcha"] = "Captcha không đúng";
                    return View("RutTien");
                }
            }
            pay.MaReviewer = Int32.Parse(ma);
            var result = db.Author.SingleOrDefault(b => b.MaReviewer == Int32.Parse(ma));
            if (Int32.Parse(money) > result.SoTien)
            {
                ViewData["Loi"] = "Số tiền muốn rút phải <= số dư ";
                return View("RutTien");
            }
            if (Int32.Parse(money) < 50000)
            {
                ViewData["Loi"] = "Số tiền muốn rút tối thiểu là 50.000đ ";
                return View("RutTien");
            }
            pay.EmailNl = emailNL;
            pay.SoTien = Int32.Parse(money);
            pay.TinhTrang = false;
            pay.NgayGio = DateTime.Now;
            db.Pay.Add(pay);
            db.SaveChanges();
            if (result != null)
            {
                result.SoTien = result.SoTien - Int32.Parse(money);
                db.SaveChanges();
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Rút Tiền", "nguyenhuuminhluan@gmail.com"));
            message.To.Add(new MailboxAddress("Rút Tiền", "nhomlbttek@gmail.com"));
            message.To.Add(new MailboxAddress("Rút Tiền", email));
            message.Subject = "Gửi yêu cầu rút tiền thành công";
            message.Body = new TextPart("html")
            {
                Text = "<b>Bạn vừa thực hiện yêu cầu rút tiền từ tài khoản có email đăng ký: </b>" + email + " với thông tin như sau:" + "<br/>" + "<b>Trạng thái:</b> chờ duyệt "
                             + "<br/>" + "<b>Số tiền rút: </b>" + String.Format("{0:0,0}", Int32.Parse(money)) + " đ" + "<br/>" + "<b>Thời gian: </b>" + DateTime.Now.ToString("H:mm - dd/MM/yyyy") + "<br/" + "<b>Email nhận tiền: </b>" + emailNL
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("nguyenhuuminhluan@gmail.com", "crbzibxcinjmamwm");
                client.Send(message);

                client.Disconnect(true);
            }
            return RedirectToAction("XacNhanRutTien");
        }

        public IActionResult XacNhanRutTien()
        {
            return View();
        }

        public IActionResult LichSURutTien(int? id, int? page)
        {
            int pageSize = 10;
            var PageNumber = (page ?? 1);
            var pay = db.Pay.OrderByDescending(a => a.IdPay).Where(b => b.MaReviewer == id);
            return View(pay.ToPagedList(PageNumber,pageSize));
        }

        public IActionResult PostBai()
        {
            if (HttpContext.Session.Get("AU") == null)
            {
                return RedirectToAction("Index");
            }
            ViewData["MaLoai"] = new SelectList(db.LoaiSp, "MaLoai", "TenLoai");
            ViewData["MaTag"] = new SelectList(db.Tag, "MaTag", "TenTag");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostBai(IFormFile HinhAnhBV, IFormCollection collection, PostBv post, CaptchaResult captcha)
        {
            var tieude = collection["TenBai"];
            var noidung = collection["NoiDung"];
            var ma = collection["MaReviewer"];
            var matag = collection["Tag"];
            var maloai = collection["MaLoai"];
            if (ModelState.IsValid)
            {
                if (!Captcha.ValidateCaptchaCode(captcha.CaptchaCode, HttpContext))
                {
                    ViewData["LoiCaptcha"] = "Captcha không đúng";
                    return View("PostBai");
                }
            }
            post.TenBai = tieude;
            post.NoiDung = noidung;
            post.MaReviewer = Int32.Parse(ma);
            post.MaLoai = Int32.Parse(maloai);
            post.MaTag = Int32.Parse(matag);
            post.TinhTrang = false;
            post.NgayViet = DateTime.Now;
            db.PostBv.Add(post);
            db.SaveChanges();
            if (HinhAnhBV == null || HinhAnhBV.Length == 0)
                return Content("file not selected");
            {
                Random rd = new Random();
                string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
                StringBuilder mann = new StringBuilder();
                for (int i = 0; i < 5; i++)
                {
                    mann.Append(pattern[rd.Next(0, pattern.Length)]);
                }
                HttpContext.Session.SetString("MaNgauNhien", mann.ToString());
                string fileName = post.MaPost + HttpContext.Session.GetString("MaNgauNhien") + Path.GetExtension(HinhAnhBV.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "SmartPhone", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await HinhAnhBV.CopyToAsync(stream);
                }
                post.HinhAnhBv = fileName;
            }
            db.Entry(post).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            return View();
        }

        public IActionResult LichSuPostBai(int? id, int? page)
        {
            int pageSize = 10;
            var PageNumber = (page ?? 1);
            var post = db.PostBv.OrderByDescending(a => a.MaPost).Where(b => b.MaReviewer == id);
            return View(post.ToPagedList(PageNumber,pageSize));
        }
    }
}