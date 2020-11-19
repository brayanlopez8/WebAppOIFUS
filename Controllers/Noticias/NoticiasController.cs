using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplicationOIFUS.Models;

namespace WebApplicationOIFUS.Controllers
{
    public class NoticiasController : Controller
    {
        private INotificacionesBLL NotificacionesBLL;
        public NoticiasController(INotificacionesBLL notificacionesBLL)
        {
            this.NotificacionesBLL = notificacionesBLL;
        }
        public IActionResult Index()
        {
            return View(NotificacionesBLL.GetAll());
        }

        public IActionResult Home()
        {
            return View(NotificacionesBLL.GetTopThree());
        }


    }
}