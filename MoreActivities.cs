using System;
using System.Collections.Generic;
using System.Text;

namespace LouisvilleFun
{
     public class MoreActivities : Activity
    {
            
            public string FoodAvailable;

            public Activity(string name, double price, string age, string food)
            {
                this.Name = name;
                this.Price = price;
                this.Age = age;
                this.FoodAvailable = food;

            }



       

    }
}
