using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards
{
    public class Award
    {
        public int id { get; set; }

        private string _title { get; set; }
        public string Title
        {
            get
            {
                return _title ?? "Unknown title";
            }
            set
            {
                if (value.Length < 50)
                {
                    _title = value;
                }
                //EXC
            }
        }

        private string _description { get; set; }
        public string Description
        {
            get
            {
                return _description ?? "No description";
            }
            set
            {
                if (value.Length < 250)
                {
                    _description = value;
                }
                //EXC
            }
        }

        public int GetAwardID()
        {
            AwardStorage.AwardIDCounter++;
            return AwardStorage.AwardIDCounter;
        }

        public Award(string title, string description)
        {
            Title = title;
            Description = description;
            id = GetAwardID();
        }
    }
}
