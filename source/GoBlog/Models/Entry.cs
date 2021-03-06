﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using GoBlog.Domain.Infrastructure.Persistence.Entities;

namespace GoBlog.Models
{
    public class EntryViewModel
    {
        // we need the slug so that we can generate a link to the entry.
        public string Slug { get; set; } 
        public string Header { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        [DisplayName("Published")]
        public DateTime PublishedAt { get; set; }   
        public bool Published { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}