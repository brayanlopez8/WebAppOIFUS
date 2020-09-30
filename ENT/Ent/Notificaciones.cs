using ENT.ParentEntities;
using System;

namespace ENT.Ent
{
    public class Notificaciones :GenericEntity
    {
        public DateTime? FechaNotificaciones { get; set; }
        public string Notificacion { get; set; }
        public string Imagen { get; set; }
    }
}
