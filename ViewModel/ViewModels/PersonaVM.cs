
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

        [Display(Name = "Orientación Sexual: ")]
        public string OrientacionSexual { get; set; }

        [Display(Name = "Nombres: ")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos: ")]
        public string Apellidos { get; set; }

        [Display(Name = "Identidad de Genero: ")]
        public string IdentidadGenero { get; set; }

        [Display(Name = "Edad: ")]
        public string Edad { get; set; }

        [Display(Name = "Etnia: ")]
        public string Etnia { get; set; }

        [Display(Name = "Telefono: ")]
        public string Telefono { get; set; }

        [Display(Name = "Localidad: ")]
        public string Localidad { get; set; }

        [Display(Name = "Es Victima de Conflicto Armado: ")]
        public string EsVictimaConflictoA { get; set; }

        [Display(Name = "Es Discapacitado: ")]
        public string EsDiscapacitado { get; set; }

        [Display(Name = "Tipo de Discapacidad: ")]
        public string TipoDiscapacidad { get; set; }

        [Display(Name = "Tipo de Vivienda: ")]
        public string TipoVivienda { get; set; }

        [Display(Name = "Seguridad Social: ")]
        public string SeguridadSocial { get; set; }

        [Display(Name = "Niviel de Escolaridad: ")]
        public string NivielEscolaridad { get; set; }

        [Display(Name = "Es JefeHogar: ")]
        public string EsJefeHogar { get; set; }

        [Display(Name = "Estrato SocioEconomico: ")]
        public string EstratiSocioEconomico { get; set; }

        [Display(Name = "Localidad de Trabajo: ")]
        public string LocalidadTrabajo { get; set; }

        [Display(Name = "Jornada de Trabajo: ")]
        public string JornadaTrabajo { get; set; }

        public int IdJornadaTrabajo { get; set; }

        public List<TblJornadaDeTrabajo> LstJornadaTrabajo { get; set; }

        [Display(Name = "Tipo de Subsidio: ")]
        public string TipoSubsidio { get; internal set; }
    }

}