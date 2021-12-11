using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo.POCOs;
namespace Komodo.Repos
{
    public class DeveloperRepo
    {
        public readonly List<Developer>_developers = new List<Developer>();
        private int _count = 0;

        //create 
        public bool CreateMember(Developer developer)
        {
            if(developer == null)
            {
                return false;
            }
            else
            {
                _count++;
                developer.Id = _count;
                _developers.Add(developer);
                return true;
            }
        }

        //public bool  CreatedDeveloper(Developer dev)
        //{
        //    int count = _developers.Count();
        //    dev.Id = count++;
        //    _developers.Add(dev);
        //    return true;
        //}

        //read
        //Read all items
        public List<Developer> GetDevelopers()
        {
            return _developers;
        }
        //Read 1 item by a property in obj
        public Developer GetDeveloperById(int id)
        {
            foreach(Developer developer in _developers)
            {
                if (id == developer.Id)
                {
                    return developer;
                }
                return null;
            }
        }
        //update
        public bool UpdateDeveloper(int id, Developer newDeveloperData)
        {
            Developer oldDeveloperInfo = GetDeveloperById(id);
            if (oldDeveloperInfo != newDeveloperData)
            {
                oldDeveloperInfo.Id = newDeveloperData.Id;
                oldDeveloperInfo.FirstName = newDeveloperData.FirstName;
                oldDeveloperInfo.LastName = newDeveloperData.LastName;
            }
        }
        //delete object by property
        public bool DeleteDeveloper(int id)
        {
            Developer DeveloperDeleted = GetDeveloperById(id);
            if (DeveloperDeleted == null)
            {
                return false;
            }
            else
            {
                _developers.Remove(DeveloperDeleted);
                return true;
            }
        }
    }
}
