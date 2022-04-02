using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace parslib.Models{
    public class Rating{
        public int RatingID{get; set;} // primary key
        public double RatingName{get; set;}
    }
}