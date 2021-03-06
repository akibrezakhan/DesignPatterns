﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.AbstractFactory
{
    // Basically an Interface
    class AbstractFactoryPatternApp
    {
        public AbstractFactoryPatternApp()
        {

        }
    }

    abstract class Furniture: Product
    {
        new public string Category { 
            get
            {
                return "Furniture";
            }
            set
            {
                throw new NotImplementedException("Cannot set catgeory name");
            }
        }
        public string SubCategory { get; set; }
        
        new public string ToString()
        {
            return $"{Name} | {SubCategory} | {Category}";
        }
    }



}
