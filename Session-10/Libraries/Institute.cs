using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries {
    public class Institute {

        // properties

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }


        // constructors

        public Institute() {

        }

        
        

        // methods

        public string? GetName() {
            return Name;

        }

        public void SetName(string name) {
            Name = name;

        }

    }
}
