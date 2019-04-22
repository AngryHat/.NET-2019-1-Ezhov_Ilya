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

        public static void Add()
        {
            usersList.Add(new User("new", "new", DateTime.Parse("2000.01.01")));
        }

        public static int UserIDCounter = 0;
    }

    class AwardStorage
    {
        public static List<Award> awardsList = new List<Award>();

        public static void Add()
        {
            awardsList.Add(new Award("new", "new"));
        }

        public static int AwardIDCounter = 0;
    }
}
