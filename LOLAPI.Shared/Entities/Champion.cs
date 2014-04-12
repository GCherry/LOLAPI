using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI.Shared.Entities
{
    public class Champion : Entity
    {
        public string ChampionName { get; set; }
        public string ChampionDesc { get; set; }
        public bool Active { get; set; }
    }
}
