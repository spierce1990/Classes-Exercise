namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Car car1 = new Car();
            car1.Make = "Pontiac";
            car1.Model = "G6";
            car1.Year = "2007";

            Car Car2 = new Car() { Make = "bmw", Model = "5", Year = "2022"};

        Console.WriteLine($"The maker of the car is {car1.Make}");
        Console.WriteLine($"The maker of the car is {car1.Model}");
        Console.WriteLine($"The maker of the car is {car1.Year}");


            Console.Write(Car2.Make);
            Console.WriteLine(Car2.Model);
            Console.WriteLine(Car2.Year);
        }


      
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