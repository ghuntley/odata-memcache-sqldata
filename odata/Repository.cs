using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odata
{
    public static class Repository
    {

        // Private list of people maintained by the Repository

        static IList<Person> _People;



        // Everytime RefreshData is called PeopleCount is increased to 

        // simulate changing data in the data source

        static int PeopleCount;





        static Repository()
        {

            _People = new List<Person>();

            PeopleCount = 5;

            RefreshData();

        }



        // Called to refresh the data from the data source

        private static void RefreshData()
        {

            ClearCollections();

            PeopleCount++;

            PopulatePeople();

        }



        // Expose the People List as an IQueryable list for the Entity

        public static IQueryable<Person> AllPeople()
        {

            return _People.AsQueryable();

        }



        // Clear the data

        private static void ClearCollections()
        {

            _People.Clear();

        }



        // Get the data from the data source

        // NOTE: For this example I’m not connecting to a DB, but this

        // is where I would handle connecting to the DB and getting 

        // the data

        private static void PopulatePeople()
        {

            for (int i = 0; i < PeopleCount; i++)
            {

                Person p = new Person();

                p.ID = i;
                p.Name = "Person #" + i;

                p.Phone = "123-4567";

                p.Age = i + 1 * 5 - 3;

                _People.Add(p);

            }

        }

    }

}