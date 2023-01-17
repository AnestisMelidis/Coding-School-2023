using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    
    public class ActionResolver {

         public enum ActionEnum {
            ConvertAndCheck,
            Uppercase,
            Reverse
        }

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() { 
        }
        public ActionResolver(MessageLogger logger) {

        }

        // METHODS

        
        public ActionResponse Execute(ActionRequest request) {


            return null;
        }


    }
}
