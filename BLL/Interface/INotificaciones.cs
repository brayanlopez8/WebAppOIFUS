using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface INotificacionesBLL
    {
        List<Notificaciones> GetTopThree();

        List<Notificaciones> GetAll();

        Notificaciones NewNotification();

        void DeleteNotification();

        Notificaciones GetNotification(int Id);

    }
}
