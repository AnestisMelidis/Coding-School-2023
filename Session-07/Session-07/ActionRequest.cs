using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {


    public class ActionRequest {

        // PROPERTIES
        public Action ActionEnum { get; set; }
        public string Input { get; set; }

        public Guid RequestID { get; set; }

        // CTOR
        public ActionRequest() {
        }
        public ActionRequest(Action actionEnum) {

        }
        public ActionRequest(Action actionEnum,string input) { 
        }
        public ActionRequest(Action actionEnum, string input,Guid requestID) {
        }



        //methods
    }

    }
