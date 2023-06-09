﻿using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuMinhHoangThuan_2080601211.Models;

namespace VuMinhHoangThuan_2080601211.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}