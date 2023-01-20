using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class University : Institute {
        
        // properties
        public List<Student> Students { get; set; }

        public List<Grade> Grades { get; set; }

        public List<Course> Courses { get; set; }

        public List<Schedule> ScheduleCourses { get; set; }


        // constructors

        public University() {
            Students = new List<Student>();

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
