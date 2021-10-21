using System.Collections.Generic;

namespace Favshows.Interfaces
{
    public interface IRepository<T> //<T> is a generic Type, how implement this interface, i say that one class implement T
    {
        List<T> List();

        T ReturnById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();

        
    }




}