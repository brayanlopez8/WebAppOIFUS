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
    public class PersonasBLL : IPersonaBLL
    {
        private UnitOfWork unitOfWork;
        private IConfiguration configuration;
        public PersonasBLL(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.unitOfWork = new UnitOfWork(configuration);

        }

        public TblPersona Create(TblPersona person)
        {
            return unitOfWork.TblPersonaRepository.add(person);
        }

        public Task<TblPersona> CreateAsync(TblPersona person)
        {
            return  unitOfWork.TblPersonaRepository.addAsyc(person);
        }

        public TblPersona GetById(int id)
        {
            return unitOfWork.TblPersonaRepository.FindFirstWhere(c => c.Id == id);
        }

        public async Task<TblPersona>  GetByIdAsync(int id)
        {
            var Persons=  await unitOfWork.TblPersonaRepository.FindFirstWhereAsync(c => c.Id == id);
            return Persons;
        }

        public List<TblPersona> GetList()
        {
          return  unitOfWork.TblPersonaRepository.Getall().ToList();
        }

        public async Task<List<TblPersona>> GetListAsync()
        {
            var Persons = await unitOfWork.TblPersonaRepository.GetallAsyc();
            return Persons.ToList();
        }

        public TblPersona Put(TblPersona person)
        {
            return unitOfWork.TblPersonaRepository.Update(person);
        }

        public async Task<TblPersona> PutAsync(TblPersona person)
        {
            var Persons = await unitOfWork.TblPersonaRepository.UpdateAsync(person);
            return Persons;
        }
    }
}
