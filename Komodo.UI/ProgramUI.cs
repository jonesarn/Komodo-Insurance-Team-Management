using Komodo.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo.POCOs;


namespace Komodo.UI
{
    class ProgramUI
    {
        DevTeamRepo _teamRepo = new DevTeamRepo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Select an option with a humber. \n"
                    + "1. Create Developer \n"
                    + "2.View a Developer \n"
                    + "3. View all Developers \n"
                    + "4.Update Developer \n"
                    + "5.Create Team \n"
                    + "6.View Team \n"
                    + "7.Update Team\n "
                    + "8.Delete Team \n"
                    + "9. Delete Developer \n"
                    + "10. End program"
                    );

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateDeveloper();
                        break;
                    case "2":
                        ViewDeveloper();
                        break;
                    case "3":
                        ViewAllDevelopers();
                        break;
                    case "4":
                        UpdateDeveloper();
                        break;
                    case "5":
                        CreateTeam();
                        break;
                    case "6":
                        ViewTeam();
                        break;
                    case "7":
                        UpdateTeam();
                        break;
                    case "8":
                        DeleteTeam();
                        break;
                    case "9":
                        DeleteDeveloper();
                        break;
                    case "10":
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
            void CreateDeveloper()
            {
                // Get First Name
                Console.WriteLine("Please give developer first name: ");
                string DevsFirstName = Console.ReadLine();

                // Get Last Name
                Console.WriteLine("Please give developer last name: ");
                string DevLastName = Console.ReadLine();
            }
            void ViewDeveloper()
            {

            }
            void ViewAllDevelopers()
            {

            }
            void UpdateDeveloper()
            {

            }
                void DeleteDeveloper()
                {

                }
                void CreateTeam()
                {

                }
                void ViewTeam()
                {

                }
                void UpdateTeam()
                {

                }
                void DeleteTeam()
                {

                }


            }
            // loop to add users to list
            //call method check method 
            //if full tell uyser



        }
    }
}
