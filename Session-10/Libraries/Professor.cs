using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Professor : Person {

        // properties

        public string? Rank { get; set; }

        public Course[] Courses { get; set; }



        // constructors

        public Professor() {

        }
       
            

        

        // methods

        public void Teach( string course,DateTime dateTime) {

        }

        public void SetGrade(Guid studentId, Guid courseId, int grade) {

        }

        public void GetName() {
            
        }

    }
}
