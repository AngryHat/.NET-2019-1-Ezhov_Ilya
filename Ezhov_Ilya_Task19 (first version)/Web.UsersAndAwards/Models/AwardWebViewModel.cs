using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Entities;

namespace Web.UsersAndAwards.Models
{
    public class AwardWebViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public AwardWebViewModel (Award award)
        {
            id = award.id;
            Title = award.Title;
            Description = award.Description;
        }
    }
}