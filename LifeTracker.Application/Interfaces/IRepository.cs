using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeTracker.Application.Interfaces
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TKey entity);

        TEntity Get(TKey key);
    }
}
