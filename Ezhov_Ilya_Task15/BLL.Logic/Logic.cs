using System;
using System.Collections.Generic;
using Entities;
using DAL.Memory;

namespace BLL.Logic
{
    public class Logic
    {
        private IStorage dataStorage;
        public Logic()
        {
            dataStorage = new MemoryDataStorage();
        }

        //add
        public void AddUser(User user)
        {
            dataStorage.AddUser(user);
        }
        public void AddUserWithParams(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            dataStorage.AddUserWithParams(fname, lname, bdate, awards);
        }
        public void AddAward(Award award)
        {
            dataStorage.AddAward(award);
        }
        public void AddAwardWithParams(string title, string description)
        {
            dataStorage.AddAwardWithParams(title, description);
        }

        //update
        public void UpdateUser(User user, string fname, string lname, DateTime bdate, List<Award> awards)
        {
            dataStorage.UpdateUser(user, fname, lname, bdate, awards);
        }
        public void UpdateAward(Award award, string title, string description)
        {
            dataStorage.UpdateAward(award, title, description);
        }


        //remove
        public void RemoveUser(User user)
        {
            dataStorage.RemoveUser(user);
        }
        public void RemoveUserById(int userId)
        {
            dataStorage.RemoveUserById(userId);
        }
        public void RemoveAward(Award award)
        {
            dataStorage.RemoveAward(award);
            foreach (User user in dataStorage.GetAllUsers())
            {
                user.Awards.Remove(award);
            }
        }
        public void RemoveAwardById(int awardId)
        {
            dataStorage.RemoveAwardById(awardId);
            Award award = dataStorage.GetAwardById(awardId);
            foreach (User user in dataStorage.GetAllUsers())
            {
                user.Awards.Remove(award);
            }
        }

        //getById
        public Award GetAwardById(int awardId)
        {
            return dataStorage.GetAwardById(awardId);
        }
        public User GetUserById(int userId)
        {
            return dataStorage.GetUserById(userId);
        }

        //getAll
        public List<User> GetAllUsers()
        {
            return dataStorage.GetAllUsers();
        }
        public List<Award> GetAllAwards()
        {
            return dataStorage.GetAllAwards();
        }

        //getAllModels
        public List<UserViewModel> GetAllUserModels()
        {
            return dataStorage.GetAllUserModels();
        }

        ////viewModels
        //public List<UserViewModel> GetUsersViewModel()
        //{
        //    List<User> allUsers = GetAllUsers();
        //    List<UserViewModel> allUserModels = new List<UserViewModel>();

        //    foreach (User user in allUsers)
        //    {
        //        allUserModels.Add(UserViewModel.GetUserViewModel(user));
        //    }
        //    return allUserModels;
        //}
        //public List<AwardViewModel> GetAwardsViewModel()
        //{
        //    List<Award> allAwards = GetAllAwards();
        //    List<AwardViewModel> allAwardModels = new List<AwardViewModel>();

        //    foreach (Award award in allAwards)
        //    {
        //        allAwardModels.Add(AwardViewModel.GetAwardViewModel(award));
        //    }
        //    return allAwardModels;
        //}
    }
}

