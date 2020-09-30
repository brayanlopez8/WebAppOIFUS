
using ENT.ParentEntities;

namespace ENT.Ent
{
    public class TblPersona: GenericEntity
    {
        public int IdPersona { get; set; }
        public long? NumeroDocumento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? IdGenero { get; set; }
        public int? IdOrientacionSexual { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? IdIdentidadGenero { get; set; }
        public int? Edad { get; set; }
        public int? IdEtnia { get; set; }
        public int? Telefono { get; set; }
        public int? IdLocalidad { get; set; }
        public bool? EsVictimaConflictoA { get; set; }
        public bool? EsDiscapacitado { get; set; }
        public int? IdTipoDiscapacidad { get; set; }
        public int? IdTipoVivienda { get; set; }
        public int? IdSeguridadSocial { get; set; }
        public int? IdNivielEscolaridad { get; set; }
        public bool? EsJefeHogar { get; set; }
        public int? IdEstratiSocioEconomico { get; set; }
        public int? IdLocalidadTrabajo { get; set; }
        public int? IdJornadaTrabajo { get; set; }
        public int? IdSubsidios { get; set; }
        public int? IdUsuario { get; set; }
    }
}
