using ENT.ParentEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace ENT.Ent
{
    public class Usuario : GenericEntity
    {

         [Column("Usuario")]
        public string Usr { get; set; }
        public string Pasword { get; set; }
        public List<TblPersona> Personas { get; set; }
    }
}
