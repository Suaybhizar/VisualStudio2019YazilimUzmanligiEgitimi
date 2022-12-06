using FreshShop.Business.Abstract;
using FreshShop.Model.Entity;
using FreshShop.Model.ViewModels;
using FreshShop.MvcWebUI.Extensions;
using FreshShop.MvcWebUI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ManagerController : Controller
    {
        private readonly IManagerBs _managerBs;

        public ManagerController(IManagerBs managerBs)
        {
            _managerBs = managerBs;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            string cookie_UN = Request.Cookies["ActiveManagerUN_CK"];
            string cookie_PW = Request.Cookies["ActiveManagerPW_Ck"];

            if (!string.IsNullOrEmpty(cookie_UN) && !string.IsNullOrEmpty(cookie_PW))
            {
                ViewData["cookie_UN"] = cookie_UN;
                ViewData["cookie_Pw"] = cookie_PW;
                ViewData["chkisChecked"] = true;
            }
            else
                ViewData["chkisChecked"] = false;

            return View();
        }

        [HttpPost]
        public IActionResult LogIn(ManagerLogInVm vm)
        {
            if (!ModelState.IsValid)
            {
                var errorMessages = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessages += error.ErrorMessage + "<br/>";
                    }
                }
                return Json(new { IsOk = false, Message = errorMessages });
            }

            Manager manager = _managerBs.LogIn(vm.UserName, vm.Password);
            if (manager != null)
            {
                if (vm.RememberMe)
                {
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddDays(2);

                    //Cookide saklanan değer Hash lenecek
                    Response.Cookies.Append("ActiveManagerUN_CK", vm.UserName, options);
                    Response.Cookies.Append("ActiveManagerPW_CK", vm.Password, options);
                }
                else
                {
                    Response.Cookies.Delete("ActiveManagerUN_CK");
                    Response.Cookies.Delete("ActiveManagerPW_CK");
                }

                HttpContext.Session.SetObject("ActiveManager", manager);


                return Json(new { IsOk = true });
            }


            return Json(new { IsOk = false, Message = "Kullanıcı Bulunamadı" });
        }

        [HttpPost]
        public IActionResult ForgotPassword(ManagerForgotPasswordVm vm)
        {
            Manager manager = _managerBs.GetByEmail(vm.Email);

            if (manager != null)
            {
                //bu yöneticinin şifresi belirtilen email hesabına gönderilecek.
                //freshShopdb2020@gmail.com
                //Fresh45!_Shop35A
                string message = $"Sayın {manager.FullName}. Şifreniz : <b>{manager.Password}</b>";

                MailHelper.SendMail(vm.Email, "Şifreniz", message);


                return Json(new { IsOk = true, Message = "şifreniz email hesanınıza gönderilmiştir." });
            }
            else
                return Json(new { IsOk = false, Message = "Bu email hesabı ile kayıtlı bir yönetici bulunamadı." });
        }

        public IActionResult Index()
        {
            List<Manager> managers = _managerBs.GetAll();
            return View(managers);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Manager vm)
        {
            _managerBs.Insert(vm);
            return Json(new { IsOk = true, Message = "Yönetici Başarıyla Kaydedildi" });
        }

        [HttpPost]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;

            if (files.Count > 0)
            {
                var fileName = files[0].FileName;
                var contentType = files[0].ContentType;
                var length = files[0].Length;// 1 KB 1024BYTE



                if (!contentType.StartsWith("image/"))

                    return Json(new { IsOk = false, Message = "Lütfen resim dosyası Seçiniz" });



                // server daki klasöre bunu kayedet
                var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(fileName));

                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanelContent/images/ManagerPhotos",
                       randomFileName);

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }

                return Json(new { IsOk = true, PhotoPath = "/AdminPanelContent/images/" + randomFileName });


            }
            else
            {
                return Json(new { IsOk = false, Message = "Lütfen Fotoğraf Seçiniz" });
            }



        }
    }
}
