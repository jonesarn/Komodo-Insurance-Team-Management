﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.UI
{
    class Program
    {
        //Our managers need to be able to add and remove members to/from a team by their unique identifier.They should be able to see a list of existing developers to choose from and add to existing teams.Odds are, the manager will create a team, and then add Developers individually from the Developer Directory to that team.
        //Challenge: Our HR Department uses the software monthly to get a list of all our Developers that need a Pluralsight license. Create this functionality in the Console Application
        //Challenge: Some of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one.Integrate this into your application.
        static void Main(string[] args)
        {
            ProgramUI UI = new ProgramUI();
            UI.Run();
        }
    }
}
