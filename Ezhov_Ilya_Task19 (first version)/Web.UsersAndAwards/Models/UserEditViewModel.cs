using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.Logic;
using Entities;

namespace Web.UsersAndAwards.Models
{
    public class UserEditViewModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string AwardsToString { get; set; }
        public List<Award> AllAwards { get; set; }
        public List<AwardForCheckbox> Awards { get; set; }

        public UserEditViewModel(User user, List<Award> allAwards)
        {
            id = user.id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            BirthDate = user.BirthDate.ToShortDateString();
            Awards = user.Awards.Select(a => new AwardForCheckbox(a)).ToList() ?? new List<AwardForCheckbox>();
            AllAwards = allAwards;
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

    public class AwardForCheckbox
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        bool IsChecked;

        public AwardForCheckbox(Award award)
        {
            id = award.id;
            Title = award.Title;
            Description = award.Description;
            IsChecked = true;
        }
    }
}