using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.POCOs
{
    //Developers have names and ID numbers; we need to be able to identify one developer without mistaking them for another.We also need to know whether or not they have access to the online learning tool: Pluralsight.
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
