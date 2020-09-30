using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface INotificaciones
    {
        List<Notificaciones> GetTopTen();

        Notificaciones NewNotification();

        void DeleteNotification();

        Notificaciones GetNotification(int Id);

    }
}
