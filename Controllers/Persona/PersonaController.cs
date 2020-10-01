using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using ENT.Ent;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOIFUS.Controllers.Persona
{
    public class PersonaController : Controller
    {
        private IPersonaBLL personaBLL;
        public PersonaController(IPersonaBLL personaBLL, ITablaTipoBLL<Contactos> contactos,
                        INotificaciones notificacionesBLL,
                        ITablaTipoBLL<TblDiscapacidad> tbldiscapacidadBLL,
                        ITablaTipoBLL<TblEstratoSocioEconomico> tblestratosocioeconomicoBLL,
                        ITablaTipoBLL<TblEtnia> tbletniaBLL,
                        ITablaTipoBLL<TblGenero> tblgeneroBLL,
                        ITablaTipoBLL<TblIdentidaDeGenero> tblidentidadegeneroBLL,
                        ITablaTipoBLL<TblJornadaDeTrabajo> tbljornadadetrabajoBLL,
                        ITablaTipoBLL<TblLocalidadTrabaja> tbllocalidadtrabajaBLL,
                        ITablaTipoBLL<TblLocalidadVive> tbllocalidadviveBLL,
                        ITablaTipoBLL<TblNivelDeEscolaridad> tblniveldeescolaridadBLL,
                        ITablaTipoBLL<TblOrientacion> tblorientacionBLL,
                        ITablaTipoBLL<TblSeguridadSocial> tblseguridadsocialBLL,
                        ITablaTipoBLL<TblSubsidio> tblsubsidioBLL,
                        ITablaTipoBLL<TblTipoDeVivienda> tbltipodeviviendaBLL,
                        ITablaTipoBLL<TblTipoDocumento> tbltipodocumentoBLL,
                        IUsuarioBLL usuarioBLL
                       )
        {
            this.personaBLL = personaBLL;
        }
        public IActionResult Index()
        {
            List<TblPersona> personas = new List<TblPersona>();
            return View(personas);
        }
    }
}