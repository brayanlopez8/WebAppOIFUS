using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using ENT.Ent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViewModel.ViewModels;

namespace WebApplicationOIFUS.Controllers.Persona
{
    public class PersonaController : Controller
    {
        private IPersonaBLL personaBLL;
        public PersonaController(IPersonaBLL personaBLL)
        {
            this.personaBLL = personaBLL;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            return View(personaBLL.GetListVM());
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            return View(personaBLL.GetById(id));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(TblPersona persona)
        {
            personaBLL.Put(persona);
            return RedirectToAction("index");
        }


    }
}