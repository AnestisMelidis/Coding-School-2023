using System;

namespace Session_11{

    public class Employee
    {
       
       public Guid ID { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       public enum EmployeeType { get; set; }
       public double SallaryPerMonth { get; set; }
    }

    /* Each shop should have: 1 Manager, 1-2 Cashiers, 1-2 Baristas and 1-3 Waiters */

    public enum EmployeeType    
    {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

 }

