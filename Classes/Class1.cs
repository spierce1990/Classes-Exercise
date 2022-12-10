using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; } = "Car make";
        public string Model { get; set; } = "Car model";

        public string Year { get; set; } = "Car Year";

    }
}

/*  Create a class named Car - make sure it is public
In the Car class:
Create a Make property of type string that is public
Create a Model property of type string that is public
Create a Year property of type int that is public
In the Main method:
Create a new instance of the Car class
Set values in the properties for the object
Print the values of each property to the Console
*/