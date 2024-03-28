using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reviewer.Models.Data;
using Reviewer.Models;
using Reviewer.ViewModel;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace Reviewer.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ReviewSPContext db;
        public AdminController(ReviewSPContext db)
        {
            this.db = db;
        }
        
        public IActionResult Index ()
        {
            //điều hướng
            if (HttpContext.Session.Get("Ad") == null)
            {
                return RedirectToAction("QLBaiViet");
            }

            if (HttpContext.Session.Get("Admin") == null)
            {
                return RedirectToAction("QLBaiViet");
            }

            var user = db.Admin.OrderByDescending(n => n.UsernameAd).Where(i => i.IsAdmin == 0 && i.Allowed == 1);
            return View(user);
        }
        [HttpGet,AllowAnonymous]
        public IActionResult Login()
        {
            ViewBag.ReturnUrl = HttpContext.Request.Query["ReturnUrl"].ToString();
            return View();
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(AdminViewModel user)
        {
            var urlReturn =
            HttpContext.Request.Query["ReturnUrl"].ToString();
            ViewBag.ReturnUrl = urlReturn;
            Admin User = db.Admin.SingleOrDefault(x => x.UsernameAd == user.UserName && x.PasswordAd == user.Password && x.Allowed == 1);
            Admin Ad = db.Admin.SingleOrDefault(n => n.UsernameAd == user.UserName && n.PasswordAd == user.Password && n.Allowed == 1 && n.IsAdmin == 1);
            if (Ad != null)
            {
                HttpContext.Session.Set("Admin", Ad);
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, Ad.AvatarAd) };
                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                HttpContext.Session.SetString("Ad", User.FullnameAd);
                if (Url.IsLocalUrl(urlReturn))
                {
                    return Redirect(urlReturn);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            if (User != null)
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, User.AvatarAd) };
                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                HttpContext.Session.SetString("Ad", User.FullnameAd);
                if (Url.IsLocalUrl(urlReturn))
                {
                    return Redirect(urlReturn);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.error = "Đăng Nhập sai bạn không có quyền vào!!!!";
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("Ad");
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login", "Admin");
        }

        public IActionResult QLKhachHang()
        {
            var khachhang = db.KhachHang.OrderByDescending(k => k.MaKh);
            return View(khachhang);
        }
        public IActionResult Sua2(int? id)
        {
            KhachHang ad = db.KhachHang.Find(id);
            return View(ad);
        }

        //Sua thong tin khach hang
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sua2(KhachHang admin, IFormFile fHinh)
        {
            KhachHang ad = db.KhachHang.SingleOrDefault(n => n.MaKh == admin.MaKh);
            ad.HoTenKh = admin.HoTenKh;
            ad.UsernameKh = admin.UsernameKh;
            ad.PassKh = admin.PassKh;
            ad.EmailKh = admin.EmailKh;
            if (fHinh == null || fHinh.Length == 0)
            {
                db.Entry(ad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("QLKhachHang");
            }
            {
                string fileName = admin.MaKh + Path.GetExtension(fHinh.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Customer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fHinh.CopyToAsync(stream);
                }
                admin.AvatarKh = fileName;
            }
            db.Entry(ad).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLKhachHang");
        }
        public IActionResult Xoa2(int? id)
        {
            KhachHang admin = db.KhachHang.Find(id);
            return View(admin);
        }
        //xoa khach hang
        [HttpPost, ActionName("Xoa2")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa2(int id)
        {
            KhachHang admin = db.KhachHang.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.KhachHang.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLKhachHang");
        }

        public ActionResult Them2(int? so)
        {
            return PartialView("~/Partials/Them2.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Them2(KhachHang kh,IFormFile image, IFormCollection coleection)
        {
            KhachHang admin = db.KhachHang.Add(kh).Entity;
            var matkhau = coleection["PassKh"];
            string passwordMD5 = MaHoa.ToMD5(matkhau);
            kh.PassKh = passwordMD5;
            db.SaveChanges();
            if (image == null || image.Length == 0)
                return Content("file not selected");
            {
                string fileName = admin.MaKh + Path.GetExtension(image.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Customer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                admin.AvatarKh = fileName;
            }
            db.Entry(admin).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLKhachHang");
        }

        public IActionResult QLReviewer()
        {
            var author = db.Author.OrderByDescending(k => k.MaReviewer);
            return View(author);
        }
        public IActionResult Sua1(int? id)
        {
            Author ad = db.Author.Find(id);
            return View(ad);
        }

        //Sua thong tin khach hang
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sua1(Author admin, IFormFile fHinh)
        {
            Author ad = db.Author.SingleOrDefault(n => n.MaReviewer == admin.MaReviewer);
            ad.FullnameRe = admin.FullnameRe;
            ad.UsernameRe = admin.UsernameRe;
            ad.PasswordRe = admin.PasswordRe;
            ad.EmailRe = admin.EmailRe;
            ad.DiaChiRe = admin.DiaChiRe;
            ad.SoTien = admin.SoTien;
            if (fHinh == null || fHinh.Length == 0)
            {
                db.Entry(ad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("QLReviewer");
            }
            else
            {
                string fileName = admin.MaReviewer + Path.GetExtension(fHinh.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Reviewer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fHinh.CopyToAsync(stream);
                }
                admin.AvatarRe = fileName;
            }
            db.Entry(ad).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLReviewer");
        }
        public IActionResult Xoa1(int? id)
        {
            Author admin = db.Author.Find(id);
            return View(admin);
        }
        //xoa khach hang
        [HttpPost, ActionName("Xoa1")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa1(int id)
        {
            Author admin = db.Author.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.Author.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLReviewer");
        }


        public ActionResult Them1(int? so)
        {
            return PartialView("~/Partials/Them1.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Them1(Author author, IFormFile imageRe, IFormCollection coleection)
        {
            Author admin = db.Author.Add(author).Entity;
            var matkhau = coleection["PasswordRe"];
            string passwordMD5 = MaHoa.ToMD5(matkhau);
            author.PasswordRe = passwordMD5;
            db.SaveChanges();
            if (imageRe == null || imageRe.Length == 0)
                return Content("file not selected");
            {
                string fileName = admin.MaReviewer + Path.GetExtension(imageRe.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Reviewer", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageRe.CopyToAsync(stream);
                }
                admin.AvatarRe = fileName;
            }
            db.Entry(admin).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLReviewer");
        }

        public IActionResult QLBaiViet()
        {
            var baiviet = db.BaiViet.Include(a => a.MaLoaiNavigation).Include(b => b.MaReviewerNavigation).Include(c => c.MaTagNavigation).OrderByDescending(k => k.MaBai).Where(a => a.TinhTrang == true);
            ViewData["MaLoai"] = new SelectList(db.LoaiSp, "MaLoai", "TenLoai");
            ViewData["MaReviewer"] = new SelectList(db.Author, "MaReviewer", "FullnameRe");
            ViewData["MaTag"] = new SelectList(db.Tag, "MaTag", "TenTag");
            return View(baiviet);
        }
        public IActionResult QLBaiVietHuyKichHoat()
        {
            var baiviet = db.BaiViet.OrderByDescending(k => k.MaBai).Where(a => a.TinhTrang == false);
            return View(baiviet);
        }
        public IActionResult KichHoatBV(int id)
        {
            var a = db.BaiViet.Find(id);
            a.TinhTrang = true;
            db.SaveChanges();
            return RedirectToAction("QLBaiViet");
        }
        public IActionResult HuyKichHoatBV(int id)
        {
            var a = db.BaiViet.Find(id);
            a.TinhTrang = false;
            db.SaveChanges();
            return RedirectToAction("QLBaiViet");
        }
        public IActionResult Them(int? so)
        {
            return PartialView("~/Partials/Them.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> Them(BaiViet bv, IFormFile HinhAnhBv, IFormCollection collection)
        {
            var tenbai = collection["TenBai"];
            var tag = collection["Tag"];
            var noidung = collection["NoiDung"];
            var reviewer = collection["MaReviewer"];
            var loai = collection["MaLoai"];
            bv.TenBai = tenbai;
            bv.NoiDung = noidung;
            bv.MaTag = Int32.Parse(tag);
            bv.LuotXem = 0;
            bv.NgayViet = DateTime.Now;
            bv.MaReviewer = Int32.Parse(reviewer);
            bv.MaLoai = Int32.Parse(loai);
            bv.TinhTrang = true;
            db.BaiViet.Add(bv);
            db.SaveChanges();
            if (HinhAnhBv == null || HinhAnhBv.Length == 0)
            {
                db.Entry(bv).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                Random rd = new Random();
                string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
                StringBuilder mann = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    mann.Append(pattern[rd.Next(0, pattern.Length)]);
                }
                HttpContext.Session.SetString("MaNgauNhien", mann.ToString());
                string fileName = bv.MaBai + HttpContext.Session.GetString("MaNgauNhien") + Path.GetExtension(HinhAnhBv.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "SmartPhone", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await HinhAnhBv.CopyToAsync(stream);
                }
                bv.HinhAnhBv = fileName;
            }
            db.Entry(bv).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QLBaiViet");
        }

        public IActionResult Sua(int? id)
        {
            BaiViet ad = db.BaiViet.Find(id);
            ViewData["MaLoai"] = new SelectList(db.LoaiSp, "MaLoai", "TenLoai", ad.MaLoai);
            ViewData["MaReviewer"] = new SelectList(db.Author, "MaReviewer", "FullnameRe", ad.MaReviewer);
            ViewData["MaTag"] = new SelectList(db.Tag, "MaTag", "TenTag", ad.MaTag);
            return View(ad);
        }

        //Sua thong tin khach hang
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sua(IFormCollection collection, IFormFile fHinh)
        {
            var mabai = collection["MaBai"];
            var tenbai = collection["TenBai"];
            var noidung = collection["NoiDung"];
            var loai = collection["MaLoai"];
            var tag = collection["MaTag"];
            var reviewer = collection["MaReviewer"];
            BaiViet ad = db.BaiViet.SingleOrDefault(n => n.MaBai == Int32.Parse(mabai));
            ad.TenBai = tenbai;
            ad.NoiDung = noidung;
            ad.MaReviewer = Int32.Parse(reviewer);
            ad.MaTag = Int32.Parse(tag);
            ad.MaLoai = Int32.Parse(loai);
            if (fHinh == null || fHinh.Length == 0)
            {
                db.BaiViet.Update(ad);
                db.SaveChanges();
                return RedirectToAction("QLBaiViet");
            }
            else
            {
                Random rd = new Random();
                string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
                StringBuilder mann = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    mann.Append(pattern[rd.Next(0, pattern.Length)]);
                }
                HttpContext.Session.SetString("MaNgauNhien", mann.ToString());
                string fileName = Int32.Parse(mabai) + HttpContext.Session.GetString("MaNgauNhien") + Path.GetExtension(fHinh.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "SmartPhone", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fHinh.CopyToAsync(stream);
                }
                ad.HinhAnhBv = fileName;
            }
            db.BaiViet.Update(ad);
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLBaiViet");
        }
        public IActionResult Xoa(int? id)
        {
            BaiViet admin = db.BaiViet.Find(id);
            return View(admin);
        }
        //xoa khach hang
        [HttpPost, ActionName("Xoa")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(int id)
        {
            BaiViet admin = db.BaiViet.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.BaiViet.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLBaiViet");
        }
        public IActionResult QLChuyenMuc()
        {
            var chuyenmuc = db.ChuyenMuc.OrderByDescending(k => k.MaMuc);
            return View(chuyenmuc);
        }
        public IActionResult ThemMuc(int? so)
        {

            return PartialView("~/Partials/ThemMuc.cshtml");
        }

        [HttpPost]
        public IActionResult ThemMuc(ChuyenMuc cm)
        {
            ChuyenMuc admin = db.ChuyenMuc.Add(cm).Entity;
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLChuyenMuc", "Admin");
        }
        public IActionResult XoaMuc(int? id)
        {
            ChuyenMuc admin = db.ChuyenMuc.Find(id);
            return View(admin);
        }
        [HttpPost, ActionName("XoaMuc")]
        [ValidateAntiForgeryToken]
        public IActionResult XoaMuc(int id)
        {
            ChuyenMuc admin = db.ChuyenMuc.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.ChuyenMuc.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLChuyenMuc");
        }
        public IActionResult SuaMuc(int? id)
        {
            ChuyenMuc ad = db.ChuyenMuc.Find(id);
            return View(ad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaMuc(ChuyenMuc admin)
        {
            ChuyenMuc ad = db.ChuyenMuc.SingleOrDefault(n => n.MaMuc == admin.MaMuc);
            ad.TenMuc = admin.TenMuc;
            ad.HinhChuyenMuc = admin.HinhChuyenMuc;
            db.Entry(ad).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QLChuyenMuc");
        }

        public IActionResult QLLoaiSp()
        {
            var loai = db.LoaiSp.OrderByDescending(k => k.MaLoai);
            return View(loai);
        }
        public IActionResult ThemLoai(int? so)
        {

            return PartialView("~/Partials/ThemLoai.cshtml");
        }

        [HttpPost]
        public IActionResult ThemLoai(LoaiSp loai)
        {
            LoaiSp admin = db.LoaiSp.Add(loai).Entity;
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLLoaiSp", "Admin");
        }
        public IActionResult XoaLoai(int? id)
        {
            LoaiSp admin = db.LoaiSp.Find(id);
            return View(admin);
        }
        [HttpPost, ActionName("XoaLoai")]
        [ValidateAntiForgeryToken]
        public IActionResult XoaLoai(int id)
        {
            LoaiSp admin = db.LoaiSp.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.LoaiSp.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLLoaiSp");
        }

        public IActionResult SuaLoai(int? id)
        {
            LoaiSp ad = db.LoaiSp.Find(id);
            return View(ad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaLoai(LoaiSp admin)
        {
            LoaiSp ad = db.LoaiSp.SingleOrDefault(n => n.MaLoai == admin.MaLoai);
            ad.TenLoai = admin.TenLoai;
            ad.MaMuc = admin.MaMuc;
            db.Entry(ad).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QLLoaiSp");
        }

        public IActionResult ThemAd(int? so)
        {

            return PartialView("~/Partials/ThemAd.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> ThemAd(Admin ad, IFormFile AvatarAd)
        {
            Admin admin = db.Admin.Add(ad).Entity;
            admin.Allowed = 1;
            admin.IsAdmin = 0;
            db.SaveChanges();
            if (AvatarAd == null || AvatarAd.Length == 0)
                return Content("file not selected");
            {
                string fileName = admin.MaAdmin + Path.GetExtension(AvatarAd.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Admin", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await AvatarAd.CopyToAsync(stream);
                }
                admin.AvatarAd = fileName;
            }
            db.Entry(admin).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("Index");
        }

        public IActionResult SuaAd(int? id)
        {

            Admin ad = db.Admin.Find(id);
            return View(ad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaAd(Admin admin, IFormFile AvatarAd)
        {
            Admin ad = db.Admin.SingleOrDefault(n => n.MaAdmin == admin.MaAdmin);
            ad.UsernameAd = admin.UsernameAd;
            ad.FullnameAd = admin.FullnameAd;
            ad.EmailAd = admin.EmailAd;
            ad.PasswordAd = admin.PasswordAd;
            if (AvatarAd == null || AvatarAd.Length == 0)
                return Content("file not selected");
            {
                string fileName = admin.MaAdmin + Path.GetExtension(AvatarAd.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "Admin", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await AvatarAd.CopyToAsync(stream);
                }
                admin.AvatarAd = fileName;
            }
            db.Entry(ad).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("Index");
        }
        public IActionResult Layid(int? id)
        {
            return RedirectToAction("SuaAd", new { @id = id });
        }

        public IActionResult XoaAd(int? id)
        {
            Admin admin = db.Admin.Find(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }
        [HttpPost, ActionName("XoaAd")]
        [ValidateAntiForgeryToken]
        public ActionResult XoaAd(int id)
        {
            Admin admin = db.Admin.Find(id);
            admin.Allowed = 0;
            db.Entry(admin).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult QLTag()
        {
            var tg = db.Tag.OrderByDescending(k => k.MaTag);
            return View(tg);
        }
        public IActionResult ThemTag(int? so)
        {

            return PartialView("~/Partials/ThemTag.cshtml");
        }

        [HttpPost]
        public IActionResult ThemTag(Tag tag)
        {
            Tag admin = db.Tag.Add(tag).Entity;
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLTag", "Admin");
        }
        public IActionResult XoaTag(int? id)
        {
            Tag admin = db.Tag.Find(id);
            return View(admin);
        }
        [HttpPost, ActionName("XoaTag")]
        [ValidateAntiForgeryToken]
        public IActionResult XoaTag(int id)
        {
            Tag admin = db.Tag.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.Tag.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLTag");
        }
        public IActionResult SuaTag(int? id)
        {
            Tag ad = db.Tag.Find(id);
            return View(ad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaTag(Tag admin)
        {
            Tag ad = db.Tag.SingleOrDefault(n => n.MaTag == admin.MaTag);
            ad.TenTag = admin.TenTag;
            db.Entry(ad).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QLTag");
        }
        public IActionResult QLTranfer()
        {
            var tranfer = db.Pay.OrderByDescending(k => k.IdPay);
            return View(tranfer);
        }
        public IActionResult KichHoatTranfer(int id)
        {
            var a = db.Pay.Find(id);
            if(a.TinhTrang == true)
            {
                return RedirectToAction("QLTranfer");
            }
            a.TinhTrang = true;
            a.NgayGioHoanTat = DateTime.Now;
            db.SaveChanges();
            var author = db.Author.SingleOrDefault(c => c.MaReviewer == a.MaReviewer);
            if (author != null)
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Rút Tiền", "nguyenhuuminhluan@gmail.com"));
                message.To.Add(new MailboxAddress("Rút Tiền", "nhomlbttek@gmail.com"));
                message.To.Add(new MailboxAddress("Rút Tiền", author.EmailRe));
                message.Subject = "Chuyển tiền thành công!";
                message.Body = new TextPart("html")
                {
                    Text = "<b>LBT Tek đã chuyển </b>" + String.Format("{0:0,0}", a.SoTien) + " đ" + " theo yêu cầu rút tiền của bạn ngày " + String.Format("{0:d/M/yyyy HH:mm:ss}", a.NgayGio) + ", bạn vui lòng kiểm tra tài khoản trên ngân lượng của mình có email là: " + a.EmailNl + "<br/>" + "<i>Chúc bạn vui vẻ và kiếm thật nhiều tiền khi tham gia cùng LBT Tek</i>"

                };
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("nguyenhuuminhluan@gmail.com", "crbzibxcinjmamwm");
                    client.Send(message);

                    client.Disconnect(true);
                }
            }
            return RedirectToAction("QLTranfer");
        }
        public IActionResult ThemTranfer(int? so)
        {

            return PartialView("~/Partials/ThemTranfer.cshtml");
        }

        [HttpPost]
        public IActionResult ThemTranfer(Pay pay)
        {
            Pay admin = db.Pay.Add(pay).Entity;
            db.SaveChanges();
            //RedirectToAction bắt buộc phải return vào 1 view
            return RedirectToAction("QLTranfer", "Admin");
        }
        public IActionResult XoaTranfer(int? id)
        {
            Pay admin = db.Pay.Find(id);
            return View(admin);
        }
        [HttpPost, ActionName("XoaTranfer")]
        [ValidateAntiForgeryToken]
        public IActionResult XoaTranfer(int id)
        {
            Pay admin = db.Pay.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.Pay.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLTranfer");
        }
        public IActionResult SuaTranfer(int? id)
        {
            Pay ad = db.Pay.Find(id);
            return View(ad);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaTranfer(Pay admin)
        {
            Pay ad = db.Pay.SingleOrDefault(n => n.IdPay == admin.IdPay);
            ad.MaReviewer = admin.MaReviewer;
            ad.EmailNl = admin.EmailNl;
            ad.SoTien = admin.SoTien;
            ad.TinhTrang = admin.TinhTrang;
            ad.NgayGio = admin.NgayGio;
            db.Entry(ad).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QLTranfer");
        }
        public IActionResult ThongKeTVTranfer()
        {
            var data = db.Pay.GroupBy(p => new
            {
                MaTV = p.MaReviewerNavigation.MaReviewer,
                TenTV = p.MaReviewerNavigation.FullnameRe
            })
            .Select(p => new
            {
                TV = $"{p.Key.MaTV}/{p.Key.TenTV}",
                Tranfer = p.Sum(q => q.SoTien)
            })
            .OrderByDescending(p => p.Tranfer)
            //.ThenByDescending(p => p.Tranfer)
            ;
            return Json(data);
        }
        public IActionResult QLPostBai()
        {
            var upload = db.PostBv.OrderByDescending(k => k.MaPost);
            return View(upload);
        }
        public async Task<IActionResult> DuyetPostBai(int id, BaiViet bv)
        {
            var a = db.PostBv.Find(id);
            var author = await db.Author.SingleOrDefaultAsync(c => c.MaReviewer == a.MaReviewer);
            if (a.TinhTrang == true)
            {
                return RedirectToAction("QLPostBai");
            }
            a.TinhTrang = true;
            a.NgayGioDuyet = DateTime.Now;
            author.SoTien = author.SoTien + 100000;
            db.SaveChanges();
            bv.TenBai = a.TenBai;
            bv.NoiDung = a.NoiDung;
            bv.NgayViet = a.NgayViet;
            bv.MaReviewer = a.MaReviewer;
            bv.HinhAnhBv = a.HinhAnhBv;
            bv.MaTag = a.MaTag;
            bv.MaLoai = a.MaLoai;
            bv.TinhTrang = true;
            bv.LuotXem = 0;
            db.BaiViet.Add(bv);
            db.SaveChanges();
            return RedirectToAction("QLPostBai");
        }
        public IActionResult XoaPostBai(int? id)
        {
            PostBv admin = db.PostBv.Find(id);
            return View(admin);
        }
        [HttpPost, ActionName("XoaPostBai")]
        [ValidateAntiForgeryToken]
        public IActionResult XoaPostBai(int id)
        {
            PostBv admin = db.PostBv.Find(id);
            db.Entry(admin).State = EntityState.Modified;
            db.PostBv.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("QLPostBai");
        }
        public IActionResult SuaPostBai(int? id)
        {
            PostBv ad = db.PostBv.Find(id);
            return View(ad);
        }
        public IActionResult XemPostBai(int? id)
        {
            PostBv post = db.PostBv.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaPostBai(PostBv admin, IFormFile fHinhPost)
        {
            PostBv ad = db.PostBv.SingleOrDefault(n => n.MaPost == admin.MaPost);
            ad.TenBai = admin.TenBai;
            ad.NoiDung = admin.NoiDung;
            ad.TinhTrang = admin.TinhTrang;
            ad.MaReviewer = admin.MaReviewer;
            db.Entry(ad).State = EntityState.Modified;
            db.SaveChanges();
            if (fHinhPost == null || fHinhPost.Length == 0)
            {
                db.Entry(ad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("QLPostBai");
            }
            {
                Random rd = new Random();
                string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
                StringBuilder mann = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    mann.Append(pattern[rd.Next(0, pattern.Length)]);
                }
                HttpContext.Session.SetString("MaNgauNhien", mann.ToString());
                string fileName = admin.MaPost + HttpContext.Session.GetString("MaNgauNhien") + Path.GetExtension(fHinhPost.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", "SmartPhone", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fHinhPost.CopyToAsync(stream);
                }
                admin.HinhAnhBv = fileName;
            }
            db.Entry(ad).State = EntityState.Modified;
            //lưu thay đổi
            db.SaveChanges();
            return RedirectToAction("QLPostBai");
        }
    }
}