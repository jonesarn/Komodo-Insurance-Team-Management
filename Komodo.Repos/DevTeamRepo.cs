using Komodo.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Komodo.Repos
{
    // Goals:
    //Create a class of 5 team members in 
    public class DevTeamRepo
    {
        private int _count = 0;

        DevTeam _devTeamRepo = new DevTeam();

        //create team
        public bool CreateTeam(DevTeam team)
        {
            if (team == null)
            {
                return false;
            }
            else
            {
                //make id for team
                team.TeamId = _count;
                _devTeamRepo.Add(team);
                return true;
            }
            
        }


        //Read

        //we need to read the teams information( first Name(dev), Last Name(dev), Id(dev)
        public List<DevTeam> GetDevTeams()
        {
            return _devTeamRepo;
        }
        //update

        //delete
        public bool DeleteDevTeam(int id)
        {
            DevTeam DevTeamDeleted = GetDevTeamById(id);
            if (DevTeamDeleted == null)
            {
                return false;
            }
            else
            {
                _devTeamRepo.Remove(DevTeamDeleted);
                return true;
            }

            //helper methods
            //this method allows me to put only five developers in a team
            public bool CountDevsInTeam(int id)
            {
                DevTeam team = GetTeamById(id);
                int counter = team.ListDev.Count();

                if (counter >= 5)
                    return true;
                else
                    return false;

            }



        }
    }
}
