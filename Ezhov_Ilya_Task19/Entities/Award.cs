using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Award
    {
        public int id { get; set; }
        private static int AwardIDCounter = 0;

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
            }
        }

        public int GetAwardID()
        {
            AwardIDCounter++;
            return AwardIDCounter;
        }

        public Award()
        {
        }

        public Award(string title, string description)
        {
            Title = title;
            Description = description;
            id = GetAwardID();
        }

        public Award(int id, string title, string description)
        {
            this.id = id;
            Title = title;
            Description = description;
        }
    }
}
