using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reviewer.Models;
using Reviewer.Models.Data;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Reviewer.ViewModel;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using X.PagedList;
using System.Text;

namespace reviewertest.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ReviewSPContext db;
        public HomeController(ReviewSPContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [ResponseCache(Duration = int.MaxValue, VaryByHeader = "id", Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Details(int? id)
        {
            var chitiet = await db.BaiViet.SingleOrDefaultAsync(m => m.MaBai == id);
            if (chitiet != null)
            {
                var author = await db.Author.SingleOrDefaultAsync(c => c.MaReviewer == chitiet.MaReviewer);
                if (author != null)
                {
                    author.SoTien = author.SoTien + ((((chitiet.LuotXem) + 1) - (chitiet.LuotXem)) * 100);
                    db.SaveChanges();
                }
                chitiet.LuotXem = (chitiet.LuotXem) + 1;
                db.SaveChanges();
                return View(chitiet);
            }
            return RedirectToAction(actionName: "Error", controllerName: "Home");
        }
        [Route("[controller]/{url}")]
        public async Task<IActionResult> DetailsBV(string url)
        {
            var chitiet = await db.BaiViet.SingleOrDefaultAsync(m => m.TenBvFriendly == url);
            if (chitiet != null)
            {
                var author = await db.Author.SingleOrDefaultAsync(c => c.MaReviewer == chitiet.MaReviewer);
                if (author != null)
                {
                    author.SoTien = author.SoTien + ((((chitiet.LuotXem) + 1) - (chitiet.LuotXem)) * 100);
                    db.SaveChanges();
                }
                chitiet.LuotXem = (chitiet.LuotXem) + 1;
                db.SaveChanges();
                return View("Details", chitiet);
            }
            return RedirectToAction(actionName: "Error", controllerName: "Home");
        }
        public IActionResult TimKiem()
        {
            return View();
        }
        //Tim Kiem Collection
        [HttpPost]
        public IActionResult TimKiem(IFormCollection collection,int? page)
        {
            int pageSize = 10;
            var pageNumber = (page ?? 1);
            string sTukhoa = collection["keyword"].ToString();
            List<BaiViet> lstb =db.BaiViet.Where(n => n.TenBai.Contains(sTukhoa)).ToList();
            if (lstb.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy kết quả!";
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstb.Count + " kết quả";
            return View(lstb.OrderBy(n=>n.MaBai).ToPagedList(pageNumber,pageSize));
        }
        //Lien He
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(IFormCollection collection, LienHe lh)
        {
            var ten = collection["name"];
            var mail = collection["email"];
            var mess = collection["message"];
            if (String.IsNullOrEmpty(ten))
            {
                ViewData["Loi1"] = "Họ tên không được để trống";
            }
            else if (String.IsNullOrEmpty(mail))
            {
                ViewData["Loi2"] = "Vui lòng nhập email";
            }
            else if (String.IsNullOrEmpty(mess))
            {
                ViewData["Loi2"] = "Vui lòng nhập tin";
            }
            else
            {
                lh.HoTen = ten;
                lh.Email = mail;
                lh.GhiChu = mess;
                db.LienHe.Add(lh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Contact();
        }
        //Lien He
        public IActionResult BaiVietTheoLoai(int? id, int? page)
        {
            int pageSize = 5;
            var pageNumber = (page ?? 1);
            BaiVietTheoLoai model = new BaiVietTheoLoai();
            var baiviet = (from a in db.LoaiSp
                           from b in db.BaiViet
                           where a.MaLoai == b.MaLoai && a.MaLoai == id && b.TinhTrang == true
                           select new Reviewer.ViewModel.BaiVietTheoLoai
                           {
                               MaLoai = a.MaLoai,
                               TenBai = b.TenBai,
                               MaBai=b.MaBai,
                           }).ToPagedList(pageNumber,pageSize);
            if (baiviet.ToList().Count == 0)
            {
                ViewBag.a = "Không tìm thấy bài viết";
            }
            return View(baiviet);
        }
        public IActionResult BaiVietTheoTG(int? id, int? page)
        {
            int pageSize = 5;
            var pageNumber = (page ?? 1);
            BaiVietTheoLoai model = new BaiVietTheoLoai();
            var baiviettg = (from a in db.Author
                             from b in db.BaiViet
                             where a.MaReviewer == b.MaReviewer && a.MaReviewer == id && b.TinhTrang == true
                             select new Reviewer.ViewModel.BaiVietTheoLoai
                             {
                                 MaLoai = a.MaReviewer,
                                 TenBai = b.TenBai,
                                 MaBai = b.MaBai,
                             }).ToPagedList(pageNumber, pageSize);
            if (baiviettg.ToList().Count == 0)
            {
                ViewBag.a = "Không tìm thấy bài viết";
            }
            return View(baiviettg);
        }
        public IActionResult BaiVietTheoTag(int? id, int? page)
        {
            int pageSize = 5;
            var pageNumber = (page ?? 1);
            BaiVietTheoLoai model = new BaiVietTheoLoai();
            var baiviettg = (from a in db.Tag
                             from b in db.BaiViet
                             where a.MaTag == b.MaTag && a.MaTag == id && b.TinhTrang == true
                             select new Reviewer.ViewModel.BaiVietTheoLoai
                             {
                                 MaLoai = a.MaTag,
                                 TenBai = b.TenBai,
                                 MaBai = b.MaBai,
                             }).ToPagedList(pageNumber, pageSize);
            if (baiviettg.ToList().Count == 0)
            {
                ViewBag.a = "Không tìm thấy bài viết";
            }
            return View(baiviettg);
        }

        public IActionResult About()
        {
            var tacgia = LayTacGia(4);
            return View(tacgia);
        }
        public List<Author> LayTacGia (int count)
        {
            return db.Author.OrderBy(a => a.MaReviewer).Take(count).ToList();
        }
       
    }
}
