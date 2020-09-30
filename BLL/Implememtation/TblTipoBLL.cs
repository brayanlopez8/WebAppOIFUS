using BLL.Interface;
using DAL.Contract;
using DAL.UnitOfWork;
using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Implememtation
{
    public class TblTipoBLL<T> : ITablaTipoBLL<T> where T : new()
    {
       
        
        private IRepository<T> repository;
        public TblTipoBLL(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<T> GetList()
        {
            return repository.Getall();
        }
    }
}
