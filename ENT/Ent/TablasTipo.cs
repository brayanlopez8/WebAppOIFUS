
using ENT.ParentEntities;
using System.Collections.Generic;

namespace ENT.Ent
{
    public class TblEtnia : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblIdentidaDeGenero : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblOrientacion : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblGenero : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblSubsidio : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblTipoDocumento : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblEstratoSocioEconomico : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblNivelDeEscolaridad : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblSeguridadSocial : GenericEntity
    {
        
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblTipoDeVivienda : GenericEntity
    {
        
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblLocalidadTrabaja : GenericEntity
    {
        
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblJornadaDeTrabajo : GenericEntity
    {
        
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblLocalidadVive : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
    public class TblDiscapacidad : GenericEntity
    {
        public string Descripcion { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
}
