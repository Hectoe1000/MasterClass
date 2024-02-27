using Azure.Identity;
using BDMaster.Models.DB;
using Microsoft.EntityFrameworkCore;
using ResquestResponsModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess
{
    public interface IUsuarioBussnies :ICRUDBussnies<UsuarioRequest,UsuarioResponse>
    {
        UsuarioResponse BuscarPorNombre(string Email);

        Vusuario VistaObtenerPorUserName(string username);
    }
}
