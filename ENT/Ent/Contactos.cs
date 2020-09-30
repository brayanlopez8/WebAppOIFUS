using ENT.ParentEntities;
using System;


namespace ENT.Ent
{
    public class Contactos : GenericEntity
    {
        public char Nombre { get; set; }
        public char Asunto { get; set; }
        public string Observacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Email { get; set; }
        public int? NumeroIdentificacion { get; set; }
    }
}
