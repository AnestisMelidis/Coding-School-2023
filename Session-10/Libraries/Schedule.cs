using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class Schedule {
       
        // properties

        public Guid ID { get; set; }

        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }


        // constructors

        public Schedule() {
            ID = Guid.NewGuid();
            CourseID = Guid.NewGuid() ;
            ProfessorID = Guid.NewGuid();
            
        }

        


        // methods

    }
}
