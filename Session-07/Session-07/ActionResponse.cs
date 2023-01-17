using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResponse {

        // PROPERTIES
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }

        public string? Output { get; set; }

        // CTOR
        public ActionResponse() {
        }
        public ActionResponse(Guid requestID) {

        }
        public ActionResponse(Guid requestID ,Guid responseID) {

        }
        public ActionResponse(Guid requestID, Guid responseID,string? output) {

        }

        //methods
        public virtual void CheckAndAct() {

         // return null;
        }
    }
}
