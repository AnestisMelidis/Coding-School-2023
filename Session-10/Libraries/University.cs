﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class University : Institute {
        
        // properties
        public List<Student> Students { get; set; }

        public List<Grade> Grades { get; set; }

        public List<Course> Courses { get; set; }

        public List<Schedule> ScheduleCourses { get; set; }


        // constructors

        public University() {
            Students = new List<Student>();
            Grades = new List<Grade>();
            Courses = new List<Course>();
            ScheduleCourses = new List<Schedule>();

        }
        


        // methods

        public void GetStudents() {

        }

        public void GetCourses() {

        }

        public void GetGrades() {

        }

        public void SetSchedule(Guid courseID,Guid professorID) {

        }
       
    }
}
