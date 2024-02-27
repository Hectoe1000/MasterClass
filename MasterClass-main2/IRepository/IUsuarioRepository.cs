using BDMaster.Models.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IUsuarioRepository:ICRUDRepository<Usuario>
    {
         Usuario ObtenerPorUserName(string username);
        Vusuario VistaObtenerPorUserName(string username);
        
         
    }
}
