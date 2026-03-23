namespace Vehicle_App_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance!");

            Car car1 = new Car("Toyota", "Camry", 2020, 120, 4, 4);
            Motorcycle mc1 = new Motorcycle("Honda", "CBR600RR", 2019, 230);
            mc1.NumberOfWheels = 2;
            Console.WriteLine(car1.Brand + " " + car1.Model + " " + car1.ModelYear + " " + car1.Speed + " " + car1.NumberOfWheels + " " + car1.NumberOfDoors);
            Console.WriteLine(mc1.Brand + " " + mc1.Model + " " + mc1.ModelYear + " " + mc1.Speed + " " + mc1.NumberOfWheels);

        }

        // Base class
        class Wheel
        {
            public int NumberOfWheels { get; set; }
        }

        // Derived class
        class Vehicle : Wheel
        {
            // Properties
            public string Brand { get; set; }
            public string Model { get; set; }
            public int ModelYear { get; set; }
            public int Speed { get; set; }

        }

        // Derived class - Subclass or Child class
        class Car : Vehicle
        {
            public Car(string brand, string model, int year, int speed, int numberOfWheels, int numberOfDoors)
            {
                Brand = brand;
                Model = model;
                ModelYear = year;
                Speed = speed;
                NumberOfWheels = numberOfWheels;
                NumberOfDoors = numberOfDoors;
            }
            public int NumberOfDoors { get; set; }
        }

        // Derived class - Subclass or Child class
        class Motorcycle : Vehicle
        {
            public Motorcycle(string brand, string model, int year, int speed)
            {
                Brand = brand;
                Model = model;
                ModelYear = year;
                Speed = speed;
            }
        }
    }
}

