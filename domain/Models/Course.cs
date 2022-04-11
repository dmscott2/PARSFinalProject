using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace domain.Models
{
    public class Course
    {
        public int CourseId {get; set;}
        public string? CourseName{get; set;}
        public int Section{get; set;}
        public string? Semester{get; set;}
        public int Academic_Year {get; set;}
        public string? Course_Status {get; set;}

    }
        public class CourseAssessment
    {
        public int CourseId {get; set;} // Primary Key, Foreign Key 1
        public int AssessmentId {get; set; } // Primary Key, Foreign Key 2
        public Course? Course {get; set;} // Navigation property back to Course
        public Assessment? Assessment{get; set;} // Navigation property back to Assessment
        
    } 
}