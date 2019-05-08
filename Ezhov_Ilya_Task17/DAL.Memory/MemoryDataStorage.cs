using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Memory
{
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
        public void AddUser(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            User newUser = new User(fname, lname, bdate, awards);
            UsersList.Add(newUser);
        }

        public void AddAward(Award award)
        {
            AwardsList.Add(award);
        }
        public void AddAward(string title, string description)
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
        public List<UserViewModel> GetAllUsersViewModels(List<User> allUsers)
        {
            List<UserViewModel> allUserModels = new List<UserViewModel>();

            foreach (User user in allUsers)
            {
                allUserModels.Add(UserViewModel.GetUserViewModel(user));
            }
            return allUserModels;
        }
        public List<AwardViewModel> GetAllAwardsViewModels(List<Award> allAwards)
        {
            List<AwardViewModel> allAwardModels = new List<AwardViewModel>();

            foreach (Award award in allAwards)
            {
                allAwardModels.Add(AwardViewModel.GetAwardViewModel(award));
            }
            return allAwardModels;
        }
    }

}
