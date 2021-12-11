using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.POCOs
{
    //Teams need to contain their Team members(Developers) and their Team Name, and Team ID.
    public class DevTeam
    {
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public List<Developer> ListDev { get; set; }
    }
}
