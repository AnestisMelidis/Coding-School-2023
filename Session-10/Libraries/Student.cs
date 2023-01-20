using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class Student : Person {

        // properties

        public int RegistrationNumber { get; set; }

        public Course Courses { get; set; }

        //constructors

        public Student() {
            //Courses = new List<Course>();
        }


        //methods

        public void Attend(string course, DateTime dateTime) {

        }

        public void WriteExam(string course, DateTime dateTime) { }

    }
}