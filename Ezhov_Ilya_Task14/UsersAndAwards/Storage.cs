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

        //public static void Edit(User currentUser)
        //{
        //    currentUser = new User("new", "new", DateTime.Parse("2000.00.00"));
        //}

        //public static void Remove(User currentUser)
        //{
        //    usersList.Remove(currentUser);
        //}
    }

    class AwardStorage
    {
        public static List<Award> awardsList = new List<Award>();

        public static void Add()
        {
            awardsList.Add(new Award("new", "new"));
        }

        //public static void Edit(Award currentAward)
        //{
        //    currentAward = new Award("new", "new");
        //}

        //public static void Remove(Award currentAward)
        //{
        //    awardsList.Remove(currentAward);
        //}
    }
}
