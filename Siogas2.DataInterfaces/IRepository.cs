using System.Collections.Generic;

namespace Siogas2.DataInterfaces
{
    public interface IRepository<Entity, EntityKeyType>
    {
        void Create(Entity entity);
        Entity Retrieve(EntityKeyType id);
        IEnumerable<Entity> RetrieveAll();
        void Update(Entity entity);
        void Delete(EntityKeyType id);
        void Delete(Entity entity);
    }
}
