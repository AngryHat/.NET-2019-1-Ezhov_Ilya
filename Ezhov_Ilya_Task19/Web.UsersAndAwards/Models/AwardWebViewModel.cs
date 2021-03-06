﻿using System;
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
        [Required(ErrorMessage = "Title can't be empty.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Title can't contains more than 50 chars.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description can't be empty.")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Description can't contains more than 50 chars.")]
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