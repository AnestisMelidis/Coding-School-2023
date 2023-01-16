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
        public Professor(Guid id) : base(id) { 

        }
        public Professor(Guid id, string name) : base(id, name) { 

        }
        public Professor(Guid id, string name, int age) : base(id, name, age) { 

        }
        public Professor(Guid id, string name, int age, string rank) : base(id, name, age) {

        }
        public Professor(Guid id, string name, int age, string rank, Course[] course) : base(id, name, age) {

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
