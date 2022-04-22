using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace domain.Models
{
    public class Assessment
    {
        public int AssessmentId {get; set;} // primary key
        public int GradeA {get; set; }
        public int GradeB {get; set; }
        public int GradeC {get; set; }
        public int GradeD {get; set; }
        public int GradeF {get; set; }
        public int GradeX {get; set; }
        public int GradeA_CIDM {get; set; }
        public int GradeB_CIDM {get; set; }
        public int GradeC_CIDM {get; set; }
        public int GradeD_CIDM {get; set; }
        public int GradeF_CIDM {get; set; }
        public int GradeX_CIDM {get; set; }
        public string? Modifications {get; set;}
        public string? Student_Feedback {get; set;}
        public string? Reflection {get; set;}
        public string? Proposed_Actions {get; set;}
    }
}