using BDMaster.Models.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CRUDRepository<TEntity> where TEntity : class
    {

        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        internal AcademiaContext db;
        //DBSET EN EL ALGUN MOMENTO SERÁ CARGO, PERSONA, COLABORADOR SE ADPTA
        internal DbSet<TEntity> dbSet;


        #region AQUI SE HACE LAS CONSULTA SQL DE LA BASE DE DATOS 
        public CRUDRepository()
        {
            db = new AcademiaContext();
            dbSet = db.Set<TEntity>();
        }

        #endregion DECLARACIÓN DE VARIABLES


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TEntity Create(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> CreateMultiple(List<TEntity> lista)
        {
            dbSet.AddRange(lista);
            db.SaveChanges();
            return lista;
        }

        //object puede ser entero, shor, string (tipo de dato primario)
        public int Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
            return db.SaveChanges();
        }

        public int DeleteMultipleItems(List<TEntity> lista)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            dbSet.Update(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }
        #endregion
    }
}
