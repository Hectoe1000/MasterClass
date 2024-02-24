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
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {



        MasterClassContext _dbMaster;

        public TipoDocumentoRepository()
            {
            _dbMaster = new MasterClassContext();
            }


        public TipoDocumento Create(TipoDocumento entity)
        {
            _dbMaster.TipoDocumentos.Add(entity);
             _dbMaster.SaveChanges();
            return entity;
        }

        public int Delete(object IdTipoDocumento)
        {
            TipoDocumento tipodoc = _dbMaster.TipoDocumentos.Find(IdTipoDocumento);
            _dbMaster.TipoDocumentos.Remove(tipodoc);
            return _dbMaster.SaveChanges();

        }

      
        public List<TipoDocumento> Getall()
        {
            List<TipoDocumento> lst= _dbMaster.TipoDocumentos.ToList();
            return lst;
        }

        public TipoDocumento GetById(int IdTipoDocumento)
        {
            TipoDocumento tipodoc = _dbMaster.TipoDocumentos.Find(IdTipoDocumento);
            return tipodoc;
        }

        public TipoDocumento Update(TipoDocumento entity)
        {
            _dbMaster.TipoDocumentos.Update(entity);
            _dbMaster.SaveChanges();
            return entity;
        }
    }
}
