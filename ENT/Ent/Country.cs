using ENT.ParentEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENT.Ent
{
    public class Country : GenericEntity
    {
        [Column("Iso")]
        public string Iso { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("PrintableName")]
        public string PrintableName { get; set; }

        [Column("Iso3")]
        public string Iso3 { get; set; }

        [Column("NumCode")]
        public string NumCode { get; set; }
    }
}
