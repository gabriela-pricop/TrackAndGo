using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackAndGo.Shared.Attributes;

namespace TrackAndGo.Shared.Enums
{
    public enum InterestTypeEnum
    {
        [Int("1")]
        [Description("Monastery")]
        Monastery = 1,
        [Description("Hiking")]
        Hiking,
        [Description("Sight-seeing")]
        SightSeeing,
        [Description("Fortress")]
        Fortress,
        [Description("Castle")]
        Castle,
        [Description("Winery")]
        Winery,
        [Description("Caving")]
        Caving,
        [Description("Natural reservation")]
        NaturalReservation,
        [Description("Entertainment")]
        Entertainment,
        [Description("Museum")]
        Museum,
        [Description("Farm")]
        Farm,
        [Description("Zoo")]
        Zoo,
        [Description("Lake")]
        Lake
    }
}
