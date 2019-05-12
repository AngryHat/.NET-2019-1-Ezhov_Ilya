using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserViewModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string AwardsToString { get; set; }
        public List<Award> Awards { get; set; }

        public static UserViewModel GetUserViewModel(User user)
        {
            var userModel = new UserViewModel();
            userModel.id = user.id;
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.Age = user.Age;
            userModel.BirthDate = user.BirthDate.ToShortDateString();
            userModel.Awards = user.Awards;
            if (user.Awards.Count == 0)
            {
                userModel.AwardsToString = "No awards, sorry";
            }
            else
            {
                userModel.AwardsToString = string.Join(", ", userModel.Awards.Select(award => award.Title));
            }
            
            return userModel;
        }



    }
}
