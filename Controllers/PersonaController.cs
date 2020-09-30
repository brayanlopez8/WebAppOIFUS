using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using ENT.Ent;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOIFUS.Controllers
{
    public class PersonaController : Controller
    {
        public PersonaController(ITablaTipoBLL<Contactos> contactos,
                        INotificaciones notificaciones,
                        IPersonaBLL person,
                        ITablaTipoBLL<TblDiscapacidad> tbldiscapacidad,
                        ITablaTipoBLL<TblEstratoSocioEconomico> tblestratosocioeconomico,
                        ITablaTipoBLL<TblEtnia> tbletnia,
                        ITablaTipoBLL<TblGenero> tblgenero,
                        ITablaTipoBLL<TblIdentidaDeGenero> tblidentidadegenero,
                        ITablaTipoBLL<TblJornadaDeTrabajo> tbljornadadetrabajo,
                        ITablaTipoBLL<TblLocalidadTrabaja> tbllocalidadtrabaja,
                        ITablaTipoBLL<TblLocalidadVive> tbllocalidadvive,
                        ITablaTipoBLL<TblNivelDeEscolaridad> tblniveldeescolaridad,
                        ITablaTipoBLL<TblOrientacion> tblorientacion,
                        ITablaTipoBLL<TblSeguridadSocial> tblseguridadsocial,
                        ITablaTipoBLL<TblSubsidio> tblsubsidio,
                        ITablaTipoBLL<TblTipoDeVivienda> tbltipodevivienda,
                        ITablaTipoBLL<TblTipoDocumento> tbltipodocumento,
                        IUsuarioBLL usuario,
                        IPersonaBLL tblpersona)
        {

        }
        public IActionResult Index()
        {
            //repository
            return View();
        }
    }
}