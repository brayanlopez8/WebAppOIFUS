using BLL.Interface;
using BLL.Utility;
using DAL.UnitOfWork;
using ENT.Ent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Implememtation
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private UnitOfWork unitOfWork;
        private IConfiguration configuration;

        public UsuarioBLL(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.unitOfWork = new UnitOfWork(configuration);
            
        }
        public Usuario CreateUser(Usuario usuario)
        {
            try
            {
                return unitOfWork.UsuarioRepository.add(usuario);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Usuario> GetAll()
        {
            try
            {
                return unitOfWork.UsuarioRepository.Getall().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario GetById(int Id)
        {
            try
            {
                return unitOfWork.UsuarioRepository.FindWhere(c => c.Id == Id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario GetUser(string Usuario, string password)
        {
            try
            {
                return unitOfWork.UsuarioRepository.FindWhere(c => c.Usr == Usuario 
                            && c.Pasword == MD5.CreateMD5(password)).FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
