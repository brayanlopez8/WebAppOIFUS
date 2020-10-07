using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using ENT.Ent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}