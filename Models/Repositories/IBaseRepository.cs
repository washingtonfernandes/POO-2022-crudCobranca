using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11CrudClient.Models.Repositories
{
    public interface IBaseRepository<Entity>
        where Entity : class
    {
        Entity GetById(int id);
        List<Entity>GetAll();
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
    }
}