using System;
using System.Collections.Generic;
using System.Text;

namespace LouisvilleFun
{
    public class Activity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Age { get; set; }

        public string Description { get; set; }

        public Activity() { }

        public Activity(string name, double price, string age, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Age = age;
            this.Description = description;

        }



    }   


}
