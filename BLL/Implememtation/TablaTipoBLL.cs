using BLL.Interface;
using DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Implememtation
{
    public class TablaTipoBLL<T> : ITablaTipoBLL<T> where T: new()
    {


        private IRepository<T> repository;
        public TablaTipoBLL(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<T> GetList()
        {
            return repository.Getall();
        }
    }
}
