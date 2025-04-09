using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAndGo.Domain.Entities
{
    public class InterestType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<PointOfInterest> PointOfInterests { get; set; } = [];//virtual performanta mai buna
        //putem sa adaugam list PointsOfInterest
    }
}
