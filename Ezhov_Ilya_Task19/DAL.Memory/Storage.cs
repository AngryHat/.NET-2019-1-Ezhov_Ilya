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
        void AddUser(string fname, string lname, DateTime bdate, List<Award> awards);
        void AddAward(Award award);
        void AddAward(string title, string description);

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

        List<UserViewModel> GetAllUsersViewModels(List<User> allUsers);
        List<AwardViewModel> GetAllAwardsViewModels(List<Award> allAwards);
    }
}
