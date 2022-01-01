﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LMSCore.Models
{
    public partial class Level
    {
        public Level()
        {
            Certificates = new HashSet<Certificate>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}