using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOIFUS.Controllers.Login
{
    public class LoginController : Controller
    {
        private IUsuarioBLL usuarioBll;

        public LoginController(IUsuarioBLL usuarioBLL)
        {
            this.usuarioBll = usuarioBLL;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ENT.Ent.Usuario usuario)
        {
            ENT.Ent.Usuario Usr = usuarioBll.GetUser(usuario.Usr, usuario.Pasword);
            if(Usr != null){
            UserManager userManager = new UserManager(usuarioBll);
            userManager.SignIn(this.HttpContext, usuario);
                return RedirectToAction("Index","Persona");
            }
            ViewData.Add("Error", "Fallo de autenticación");
            return View();
        }

        public IActionResult ClosedSession(){
            UserManager  userManager = new UserManager(usuarioBll);
            userManager.SignOut(this.HttpContext);
            return RedirectToAction("Index","Login");
        }
    }
}