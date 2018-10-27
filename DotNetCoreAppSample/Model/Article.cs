﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCoreAppSample.Model
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Uri { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
