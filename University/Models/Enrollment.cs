using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Models
{
    public enum GradeEnum
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public GradeEnum? Grade { //? - is nullable
            get {
                return (GradeEnum?)GradeInternal;
            } 
            set {
                GradeInternal = (int?)value;
            }
        } 
        public int? GradeInternal { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}