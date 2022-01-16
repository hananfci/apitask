using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Model.repositories
{
   public interface ITaskRepository<IEntity>
    {
        List<IEntity> List();
        IEntity Find(int id);
        IEntity Add(IEntity entity);
        IEntity Update(int id, IEntity entity);
        bool Delete(int id);
    }
}
