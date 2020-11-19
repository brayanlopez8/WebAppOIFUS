using BLL.Interface;
using DAL.UnitOfWork;
using ENT.Ent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Implememtation
{
    public class NotificacionesBLL : INotificacionesBLL
    {
        private UnitOfWork unitOfWork;
        private IConfiguration configuration;
        public NotificacionesBLL(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.unitOfWork = new UnitOfWork(configuration);
            
        }
        public void DeleteNotification()
        {
            //this.repository = repository;
            throw new NotImplementedException();

        }

        public Notificaciones GetNotification(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Notificaciones> GetTopThree()
        {
           return unitOfWork.NotificacionesRepository.Getall().Take(3).OrderBy(c=> c.DateCreated).ToList();
        }
        public List<Notificaciones> GetAll()
        {
           return unitOfWork.NotificacionesRepository.Getall().ToList();
        }

        public Notificaciones NewNotification()
        {
            throw new NotImplementedException();
        }
    }
}
