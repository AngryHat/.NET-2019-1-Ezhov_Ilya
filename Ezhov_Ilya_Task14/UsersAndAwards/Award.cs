using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards
{
    class Award
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

        private string _decription { get; set; }
        public string Decsrition
        {
            get
            {
                return _decription ?? "No description";
            }
            set
            {
                if (value.Length < 250)
                {
                    _decription = value;
                }
                //EXC
            }
        }

        public Award(string title, string description)
        {
            Title = title;
            Decsrition = description;
        }
    }
}
