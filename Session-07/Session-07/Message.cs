using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class Message {
        // PROPERTIES
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessageLoggerMessage { get; set; }

        // CTOR
        public Message() { 
        }
        public Message(Guid id) {
        }
        public Message(Guid id, DateTime timeStamp) {
        }
        public Message(Guid id,DateTime timeStamp,string? messageLoggerMessage) {
        }

    }
}
