﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LMSCore.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}