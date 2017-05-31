using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //Grade property is an enum
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //? indicates that the grade property is nullable, ie grade may not be assigned yet.
        public Grade? Grade { get; set; }

        // Course navigation property. Enrollment is associated with one course only
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
//Entity Framework interprets a property as a foreign key property if it's named 
//<navigation property name><primary key property name> (for example, StudentID for the Student navigation 
//property since the Student entity's primary key is ID). Foreign key properties can also be named simply 
//<primary key property name> (for example, CourseID since the Course entity's primary key is CourseID).
