using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAndGo.Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(Type entityType) : base($"Entity of type {entityType.Name} not found")
        {
            
        }
        public EntityNotFoundException(Type entityType, int id) : base($"Entity of type {entityType.Name} with id: {id} not found")
        {

        }
    }
}
