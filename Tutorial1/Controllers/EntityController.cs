using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tutorial1.Models;

namespace Tutorial1.Controllers
{
    public class EntityController : ApiController
    {
        Entity[] entities = new Entity[]
        {
            new Entity { id=1, name="Norton Pengra", age=19, health=100 },
            new Entity { id=2, name="Oliver Collins", age=19, health=200 },
            new Entity { id=3, name="PengraBot", age=1, health=2000 },
        };

        public IEnumerable<Entity> GetAllEntities()
        {
            return entities;
        }

        public IHttpActionResult GetEntity(int id)
        {
            Entity entity = entities.FirstOrDefault((e) => e.id == id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
    }
}
