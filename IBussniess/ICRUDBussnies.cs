using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess
{
    public interface ICRUDBussnies<T,Y>:IDisposable
    {
        #region AQUI SE ENCUENTAN LOS METODOS PERO DEL RESPONSE(Y) , RESQUEST(T) 

        List<Y> GetAll();
        Y GetById(int id);
        Y Create(T entity);
        Y Update(T entity);
        int Delete(int id);
        int DeleteMultipleItems(List<T> lista);
        List<Y> InsertMultiple(List<T> lista);
        List<Y> UpdateMultiple(List<T> lista);
        #endregion
    }
}
