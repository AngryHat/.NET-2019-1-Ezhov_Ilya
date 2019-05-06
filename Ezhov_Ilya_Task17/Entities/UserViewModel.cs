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
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Awards { get; set; }

        public static UserViewModel GetUserViewModel(User user)
        {
            var userModel = new UserViewModel();
            userModel.id = user.id;
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.Age = user.Age;
            userModel.BirthDate = user.BirthDate;
            userModel.Awards = string.Join(", ", user.Awards.Select(award => award.Title));

            return userModel;
        }
    }
}
