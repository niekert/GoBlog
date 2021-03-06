﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GoBlog.Areas.Admin.Models
{
    public class EntryInput
    {
        [HiddenInput]
        public string Slug { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        [AllowHtml]
        public string Content { get; set; }

        public bool Published { get; set; }

        [Required]
        public string Tags { get; set; }
    }
}