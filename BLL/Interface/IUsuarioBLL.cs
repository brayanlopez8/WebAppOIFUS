using ENT.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IUsuarioBLL
    {
        List<Usuario> GetAll();

        Usuario GetById(int Id);

        Usuario GetUser(string Usuario, string Password);

        Usuario CreateUser(Usuario usuario);



    }
}
