using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class Person {

        // properties
        public Guid ID { get; set; }  

        public string? Name { get; set; }

        public int Age { get; set; }

        // constructors

        public Person() {
            ID= Guid.NewGuid();

        }
       


        // methods

        public void GetName() {

        }

        public void SetName(string name) {

        }
    }

}
