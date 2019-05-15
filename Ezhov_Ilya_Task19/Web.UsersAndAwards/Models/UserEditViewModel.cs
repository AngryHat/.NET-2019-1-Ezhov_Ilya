using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BLL.Logic;
using Entities;

namespace Web.UsersAndAwards.Models
{
    public class UserEditViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "First name can't be empty.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name can't contains more than 50 chars.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First name can't be empty.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name can't contains more than 50 chars.")]
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public List<AwardForCheckbox> AwardsCheckBox { get; set; }
        public List<Award> Awards { get; set; }

        public UserEditViewModel(User user, List<Award> allAwards)
        {
            id = user.id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate.ToShortDateString();
            Awards = user.Awards;
            AwardsCheckBox = allAwards.Select(a => new AwardForCheckbox(a, false)).ToList();
            for (int i = 0; i < allAwards.Count; i ++)
            {
                var isChecked = Awards.Contains(allAwards[i]);
                AwardsCheckBox[i].IsChecked = isChecked;
            }
        }

        public UserEditViewModel()
        {
        }
    }

    public class AwardForCheckbox
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }

        public AwardForCheckbox(Award award, bool isChecked)
        {
            id = award.id;
            Title = award.Title;
            Description = award.Description;
            IsChecked = isChecked;
        }

        public AwardForCheckbox()
        {
            //new List<AwardForCheckbox>();
        }
    }


}