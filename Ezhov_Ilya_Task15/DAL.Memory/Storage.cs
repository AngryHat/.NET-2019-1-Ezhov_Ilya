using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Memory
{
    //interface IStorage
    //{
    //    void Add();
    //    void Edit();
    //    void Remove();
    //}
    public interface IStorage
    {

        void AddUser(User user);
        void AddUserWithParams(string fname, string lname, DateTime bdate, List<Award> awards);
        void AddAward(Award award);
        void AddAwardWithParams(string title, string description);

        void UpdateUser(User user, string fname, string lname, DateTime bdate, List<Award> awards);
        void UpdateAward(Award award, string title, string description);

        void RemoveUser(User user);
        void RemoveUserById(int userId);
        void RemoveAward(Award award);
        void RemoveAwardById(int awardId);

        Award GetAwardById(int awardId);
        User GetUserById(int userId);

        List<User> GetAllUsers();
        List<Award> GetAllAwards();

        List<UserViewModel> GetAllUserModels();
    }

    public class MemoryDataStorage : IStorage
    {
        public static List<User> UsersList;
        public static List<Award> AwardsList;

        public static List<UserViewModel> UserModelsList;
        public static List<AwardViewModel> AwardModelsList;

        public MemoryDataStorage()
        {
            UsersList = new List<User>();
            AwardsList = new List<Award>();
        }

        //add
        public void AddUser(User user)
        {
            UsersList.Add(user);
        }
        public void AddUserWithParams(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            User newUser = new User(fname, lname, bdate, awards);
            UsersList.Add(newUser);
        }

        public void AddAward(Award award)
        {
            AwardsList.Add(award);
        }
        public void AddAwardWithParams(string title, string description)
        {
            Award newAward = new Award(title, description);
            AwardsList.Add(newAward);
        }

        //update
        public void UpdateUser(User user, string fname, string lname, DateTime bdate, List<Award> awards)
        {
            user.FirstName = fname;
            user.LastName = lname;
            user.BirthDate = bdate;
            user.Awards = awards;
        }
        public void UpdateAward(Award award, string title, string description)
        {
            award.Title = title;
            award.Description = description;
        }

        //remove
        public void RemoveUser(User user)
        {
            UsersList.Remove(user);
        }
        public void RemoveUserById(int userId)
        {
            User user = GetUserById(userId);
            UsersList.Remove(user);
        }
        
        public void RemoveAward(Award award)
        {
            AwardsList.Remove(award);
        }
        public void RemoveAwardById(int awardId)
        {
            Award award = GetAwardById(awardId);
            AwardsList.Remove(award);
        }

        //get by id
        public Award GetAwardById(int awardId)
        {
            Award award = AwardsList.Find(a => a.id == awardId);
            return award;
        }
        public User GetUserById(int userId)
        {
            User user = UsersList.Find(u => u.id == userId);
            return user;
        }

        //getAll
        public List<User> GetAllUsers()
        {
            return UsersList;
        }
        public List<Award> GetAllAwards()
        {
            return AwardsList;
        }

        //convertToModels
        public List<UserViewModel> GetAllUserModels()
        {
            List<UserViewModel> userModels = new List<UserViewModel>();
            foreach (var user in UsersList)
            {
                userModels.Add(UserViewModel.GetUserViewModel(user));
            }
            return userModels;
        }
    }


    ////old version
    //public class UserStorage
    //{
    //    public static List<User> UsersList = new List<User>();

    //    public static void Add(string fName, string lName, DateTime bDate, List<Award> awards)
    //    {
    //        UsersList.Add(new User(fName, lName, bDate, awards));
    //    }
    //}

    //public class AwardStorage
    //{
    //    public static List<Award> AwardsList = new List<Award>();

    //    public static void Add(string title, string description)
    //    {
    //        AwardsList.Add(new Award(title, description));
    //    }
    //}
}
