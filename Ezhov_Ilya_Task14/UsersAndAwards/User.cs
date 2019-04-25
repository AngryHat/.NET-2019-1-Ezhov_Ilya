using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards
{
    public class User
    {
        public int id { get; set; }

        private string _firstName { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 50)
                {
                    _firstName = value;
                }
                //EXC
            }
        }
        private string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 50)
                {
                    _lastName = value;
                }
                //EXC
            }
        }
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (value < DateTime.Now && ((DateTime.Now.Year - value.Year) < 150))
                {
                    _birthDate = value;
                }
            }
            //EXC
        }
        public int Age
        {
            get
            {
                int _ageCorrection = 0;
                if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
                {
                    _ageCorrection = 1;
                }
                return DateTime.Now.Year - BirthDate.Year - _ageCorrection;
            }
        }

        public List<Award> Awards = new List<Award>();

        public string AwardsToString
        {
            get
            {
                string output = "No awards, sorry";
                if (Awards.Count != 0)
                {
                    output = "";
                    int i;
                    for (i = 0; i < Awards.Count - 1; i++)
                    {
                        output += Awards[i].Title + ", ";
                    }
                    output += Awards[i].Title;
                    //foreach (var award in Awards)
                    //{
                    //    output += award.Title + ", ";
                    //}
                }

                //string.Join(", ", ); //вместо аутпуда для стринга
                return output;
            }
        }

        public int GetUserID()
        {
            UserStorage.UserIDCounter++;
            return UserStorage.UserIDCounter;
        }


        public User()
        {
        }

        public User(string fname, string lname, DateTime bdate)
        {
            id = GetUserID();
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
        }

        public User(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            id = GetUserID();
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            Awards = awards;
        }
    }
}
