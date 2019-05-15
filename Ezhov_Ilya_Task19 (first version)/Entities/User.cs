using System;
using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public int id { get; set; }
        public static int UserIDCounter = 0;
        
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

        public List<Award> Awards;

        //unnecessary since VM classes woks
        public string AwardsToString
        {
            get
            {
                string output = "No awards, sorry";
                if (Awards.Count != 0)
                {
                    output = "";
                    List<string> awardsTitles = new List<string>();
                    foreach (Award award in Awards)
                    {
                        awardsTitles.Add(award.Title);
                    }
                    output = String.Join(", ", awardsTitles);
                }
                return output;
            }
        }

        public int GetUserID()
        {
            UserIDCounter++;
            return UserIDCounter;
        }


        public User()
        {
            Awards = new List<Award>();
        }

        public User(string fname, string lname, DateTime bdate)
        {
            id = GetUserID();
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            Awards = new List<Award>();
        }

        public User(string fname, string lname, DateTime bdate, List<Award> awards)
        {
            id = GetUserID();
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            Awards = awards ?? new List<Award>();
        }

        public User(int id, string fname, string lname, DateTime bdate, List<Award> awards)
        {
            this.id = id;
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            Awards = awards ?? new List<Award>();
        }
    }
}
