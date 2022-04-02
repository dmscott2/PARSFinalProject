using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace parslib.Models
{
    public class Assessment
    {
        public int AssessmentId {get; set;} // primary key
        public string? Modifications {get; set;}
        public string? Student_Feedback {get; set;}
        public string? Reflection {get; set;}
        public string? Proposed_Actions {get; set;}
    }
}