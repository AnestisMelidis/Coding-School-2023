﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    public class ProductCategory {
        
        


        //Properties
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }

        public List<Product>? products;
        

        

        public ProductCategory()
        {
            ID = Guid.NewGuid();
            List<Product>? products = new List<Product>();
        }

        //Constractors
       

        //Methods


    }
}
