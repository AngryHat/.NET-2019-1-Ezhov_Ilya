using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Web.UsersAndAwards.Models
{
    public class UserWebViewModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string AwardsToString { get; set; }
        public List<Award> Awards { get; set; }

        public UserWebViewModel(User user)
        {
            id = user.id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            BirthDate = user.BirthDate.ToShortDateString();
            Awards = user.Awards ?? new List<Award>();
            if (user.Awards.Count == 0)
            {
                AwardsToString = "No awards, sorry";
            }
            else
            {
                AwardsToString = string.Join(", ", Awards.Select(award => award.Title));
            }
        }
    }
}