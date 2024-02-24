
using BDMaster.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ITipoDocumentoRepository
    {
        List<TipoDocumento> Getall();
        TipoDocumento GetById(int id);
        TipoDocumento Create(TipoDocumento entity);
        TipoDocumento Update(TipoDocumento entity);
        int Delete(object id);
    }
}
