using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class Grade {
       
        // properties
      
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }

        public int Mark { get; set; }

        // constructors
        public Grade() {
        }

       


        // methods


    }
}
