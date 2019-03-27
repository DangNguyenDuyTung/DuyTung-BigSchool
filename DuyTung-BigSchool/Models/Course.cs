﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuyTung_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string LectureId { get; set; }
        [Required]
        [StringLength(255)]
        public string Plae { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}