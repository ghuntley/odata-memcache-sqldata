using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odata
{

    public class PeopleEntities
    {

        public PeopleEntities() { }

        public IQueryable<Person> People
        {

            get { return Repository.AllPeople(); }

        }

    }
}