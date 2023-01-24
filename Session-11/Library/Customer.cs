using System;



namespace Library
{
    public class Customer
    { 
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        
        //Constructors
        public Customer() {
            ID = Guid.NewGuid();
        }
       
        
        //Methods
        public void TestMethod() {

        }


    }

   

    
     

}



