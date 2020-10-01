﻿using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IPersonaBLL
    {

        List<TblPersona> GetList();
        Task<List<TblPersona>> GetListAsync();
        TblPersona GetById(int id);
        Task<TblPersona> GetByIdAsync(int id);
        TblPersona Create(TblPersona person);
        Task<TblPersona> CreateAsync(TblPersona person);
        Task<TblPersona> PutAsync(TblPersona person);
        TblPersona Put(TblPersona person);
    }
}