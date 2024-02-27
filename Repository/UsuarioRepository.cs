using BDMaster.Models.DB;
using IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : CRUDRepository<Usuario>, IUsuarioRepository
    {
        public Usuario ObtenerPorUserName(string username)
        {
            Usuario usuario = 
                dbSet.Where(x => x.Email.ToLower() == username.ToLower()).FirstOrDefault();

            return usuario;
        }

    }
} 
