using System;
using System.Collections.Generic;
using System.Text;

namespace LouisvilleFun
{
    public class MoreActivities : Activity
    {

        public MoreActivities(string name, double price, string age, string food)
            : base(name, price, age, food)

            {
      
                this.FoodAvailable = food;
            }
     }       

}
