using System;
using System.Collections.Generic;
using Favshows.Interfaces;

namespace Favshows
{

    public class ShowRepository : IRepository<Show> //This ShowRepository class implements the interface IRespotory but of the class Shows
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Show entity)
        {
            throw new NotImplementedException();
        }

        public List<Show> List()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Show ReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Show entity)
        {
            throw new NotImplementedException();
        }
    }
}