using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards
{
    //interface IStorage
    //{
    //    void Add();
    //    void Edit();
    //    void Remove();
    //}

    class UserStorage
    {
        public static List<User> usersList = new List<User>();

        public static void Add(string fName, string lName, DateTime bDate, List<Award> awards)
        {
            usersList.Add(new User(fName, lName, bDate, awards));
        }

        public static int UserIDCounter = 0;
    }

    class AwardStorage
    {
        public static List<Award> awardsList = new List<Award>();

        public static void Add(string title, string description)
        {
            awardsList.Add(new Award(title, description));
        }

        public static int AwardIDCounter = 0;
    }
}
