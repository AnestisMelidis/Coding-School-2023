﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Grade {
       
        // properties
      
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }

        public int Mark { get; set; }

        // constructors
        public Grade() {
        }

        public Grade(Guid id) {
            ID = id;
        }

        public Grade(Guid id,Guid studentId) {
            ID = id;
            StudentID = studentId;    
        }

        public Grade(Guid id, Guid studentId, Guid courseId) {
            ID = id;
            StudentID = studentId;
            CourseID = courseId;
        }

        public Grade(Guid id, Guid studentId, Guid courseId,int mark) {
            ID = id;
            StudentID = studentId;
            CourseID = courseId;
            Mark = mark;
        }


        // methods


    }
}
