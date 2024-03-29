﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07 {

    public enum ActionEnum {
        Convert,
        Uppercase,
        Reverse
    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() {
            Logger = new MessageLogger();
        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {


            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;
            
           
            StringManipulator stringManipulator;


            Log("EXECUTION START");

            try {

                switch (request.Action) {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                      
                        stringManipulator = new StringConvert();
                        stringManipulator.Manipulate();
                        break;

                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                      
                        stringManipulator = new StringUpperCase();
                        stringManipulator.Manipulate();
                        
                        break;

                    case ActionEnum.Reverse:
                        Log("REVERSE");
                      
                        stringManipulator = new StringReverse();
                        stringManipulator.Manipulate();
                        break;

                    default:
                        // TODO: ERRORMESSAGE!
                        break;
                }
            }
            catch (Exception ex) {
                Log(ex.Message);

            }
            finally {
                Log("EXECUTION END");
            }


            return response;
        }



        private void Log(string text) {

            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message);
        }

        


    }
}