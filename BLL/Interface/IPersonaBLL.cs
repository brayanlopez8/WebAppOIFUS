using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.ViewModels;

namespace BLL.Interface
{
    public interface IPersonaBLL
    {

        List<TblPersona> GetList();

         List<PersonaVM> GetListVM();
        Task<List<TblPersona>> GetListAsync();
        TblPersona GetById(int id);
        Task<TblPersona> GetByIdAsync(int id);
        TblPersona Create(TblPersona person);
        TblPersona Create(PersonaVM person);
        Task<TblPersona> CreateAsync(TblPersona person);
        Task<TblPersona> PutAsync(TblPersona person);
        TblPersona Put(TblPersona person);
        TblPersona Put(PersonaVM person);

        PersonaVM GetPersonaById(int id);
        PersonaVM GetNewPersona();
    }
}
