
using ENT.ParentEntities;

namespace ENT.Ent
{
    public class TblPersona : GenericEntity
    {

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

        public int ValidarTipoDocumento()
        {
            if (this.IdTipoDocumento == null)
            {
                return 0;
            }
            return this.IdTipoDocumento.Value;
        }
        public int ValidarGenero()
        {
            if (this.IdGenero == null)
            {
                return 0;
            }
            return this.IdGenero.Value;
        }
        public int ValidarOrientacionSexual()
        {
            if (this.IdOrientacionSexual == null)
            {
                return 0;
            }
            return this.IdOrientacionSexual.Value;
        }
        public int ValidarIdentidadGenero()
        {
            if (this.IdIdentidadGenero == null)
            {
                return 0;
            }
            return this.IdIdentidadGenero.Value;
        }
        public int ValidarEtnia()
        {
            if (this.IdEtnia == null)
            {
                return 0;
            }
            return this.IdEtnia.Value;
        }
        public int ValidarLocalidad()
        {
            if (this.IdLocalidad == null)
            {
                return 1;
            }
            return this.IdLocalidad.Value;
        }
        
        public int ValidarTipoDiscapacidad()
        {
            if (this.IdTipoDiscapacidad == null)
            {
                return 0;
            }
            return this.IdTipoDiscapacidad.Value;
        }
        public int ValidarTipoVivienda()
        {
            if (this.IdTipoVivienda == null)
            {
                return 0;
            }
            return this.IdTipoVivienda.Value;
        }
        public int ValidarSeguridadSocial()
        {
            if (this.IdSeguridadSocial == null)
            {
                return 0;
            }
            return this.IdSeguridadSocial.Value;
        }
        public int ValidarNivielEscolaridad()
        {
            if (this.IdNivielEscolaridad == null)
            {
                return 0;
            }
            return this.IdNivielEscolaridad.Value;
        }
        
        public int ValidarEstratiSocioEconomico()
        {
            if (this.IdEstratiSocioEconomico == null)
            {
                return 0;
            }
            return this.IdEstratiSocioEconomico.Value;
        }
        public int ValidarLocalidadTrabajo()
        {
            if (this.IdLocalidadTrabajo == null)
            {
                return 1;
            }
            return this.IdLocalidadTrabajo.Value;
        }
        public int ValidarJornadaTrabajo()
        {
            if (this.IdJornadaTrabajo == null)
            {
                return 0;
            }
            return this.IdJornadaTrabajo.Value;
        }
        public int ValidarSubsidios(){
            if (this.IdSubsidios == null)
            {
                return 0;
            }
            return this.IdSubsidios.Value;
        }
    }
}
