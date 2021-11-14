using System;
using System.Collections.Generic;
using System.Text;

namespace LouisvilleFun
{
    public class MoreActivities : Activity
    {
        public string FoodAvailable;
        
        
        public MoreActivities(string name, double price, string age, string food)
            : base(name, price, age)

            {
      
                this.FoodAvailable = food;
            }
     }       

}
