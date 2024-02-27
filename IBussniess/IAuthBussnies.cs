using ResquestResponsModel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess
{
    public interface IAuthBussnies
    {
        LoginResponse Login(LoginRequest request);
    }
}
