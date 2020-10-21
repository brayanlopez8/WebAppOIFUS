
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ENT.Ent;

namespace ViewModel.ViewModels
{
    public class PersonaVM
    {
        public int Id { get; set; }

        [Display(Name = "Número Documento: ")]
        public string NumeroDocumento { get; set; }

        [Display(Name = "Tipo Documento: ")]
        public string TipoDocumento { get; set; }

        [Display(Name = "Tipo Documento: ")]
        public int IdTipoDocumento { get; set; }

        public List<TblTipoDocumento> LstTipoDocumento { get; set; }

        [Display(Name = "Genero: ")]
        public string Genero { get; set; }
        public List<TblGenero> LstGenero { get; set; }
        public int IdGenero { get; set; }

        [Display(Name = "Orientación Sexual: ")]
        public string OrientacionSexual { get; set; }

        public int IdOrientacionSexual { get; set; }
        public List<TblOrientacion> LstOrientacionSexual { get; set; }

        [Display(Name = "Nombres: ")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos: ")]
        public string Apellidos { get; set; }

        [Display(Name = "Identidad de Genero: ")]
        public string IdentidadGenero { get; set; }
        public int IdIdentidadGenero { get; set; }
        public List<TblIdentidaDeGenero> LstIdentidadGenero { get; set; }

        [Display(Name = "Edad: ")]
        public string Edad { get; set; }

        [Display(Name = "Etnia: ")]
        public string Etnia { get; set; }

        public int IdEtnia { get; set; }
        public List<TblEtnia> LstEtnia { get; set; }

        [Display(Name = "Telefono: ")]
        public string Telefono { get; set; }

        [Display(Name = "Localidad: ")]
        public string Localidad { get; set; }
        public int IdLocalidad { get; set; }
        public List<TblLocalidadVive> LstLocalidad { get; set; }

        [Display(Name = "Es Victima de Conflicto Armado: ")]
        public string EsVictimaConflictoA { get; set; }

        [Display(Name = "Es Discapacitado: ")]
        public string EsDiscapacitado { get; set; }

        [Display(Name = "Tipo de Discapacidad: ")]
        public string TipoDiscapacidad { get; set; }

        public int IdTipoDiscapacidad { get; set; }
        public List<TblDiscapacidad> LstDiscapacidad { get; set; }

        [Display(Name = "Tipo de Vivienda: ")]
        public string TipoVivienda { get; set; }
        public int IdTipoVivienda { get; set; }
        public List<TblTipoDeVivienda> LstTipoVivienda { get; set; }

        [Display(Name = "Seguridad Social: ")]
        public string SeguridadSocial { get; set; }
        public int IdSeguridadSocial { get; set; }
        public List<TblSeguridadSocial> LstSeguridadSocial { get; set; }

        [Display(Name = "Niviel de Escolaridad: ")]
        public string NivielEscolaridad { get; set; }
        public int IdNivielEscolaridad { get; set; }
        public List<TblNivelDeEscolaridad> LstNivielEscolaridad { get; set; }

        [Display(Name = "Es JefeHogar: ")]
        public string EsJefeHogar { get; set; }

        [Display(Name = "Estrato SocioEconomico: ")]
        public string EstratiSocioEconomico { get; set; }
        public int IdEstratiSocioEconomico { get; set; }
        public List<TblEstratoSocioEconomico> LstEstratiSocioEconomico { get; set; }

        [Display(Name = "Localidad de Trabajo: ")]
        public string LocalidadTrabajo { get; set; }
        public int IdLocalidadTrabajo { get; set; }
        public List<TblLocalidadTrabaja> LstLocalidadTrabajo { get; set; }

        [Display(Name = "Jornada de Trabajo: ")]
        public string JornadaTrabajo { get; set; }

        public int IdJornadaTrabajo { get; set; }

        public List<TblJornadaDeTrabajo> LstJornadaTrabajo { get; set; }

        [Display(Name = "Tipo de Subsidio: ")]
        public string TipoSubsidio { get; internal set; }
        public int IdTipoSubsidio { get; internal set; }
        public List<TblSubsidio> LstTipoSubsidio { get; set; }

        [Display(Name = "Estado Persona: ")]
        public bool EstadoPersona { get; set; }
    }

}