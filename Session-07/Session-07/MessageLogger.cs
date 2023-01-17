using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {
        // PROPERTIES
        public Message[] Messages { get; set; }


        // CTOR
        public MessageLogger() {

        }
        public MessageLogger(Message message) {
            Messages = new Message[1000];
        }

        //methods
        public void ReadAll() {

        }

        public void Write(Message Messages) {
            int i = 0;
            if (Messages != null) {

            }
        }

        public void Clear() {

        }
    }
}
