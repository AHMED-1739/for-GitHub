using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_GitHub
{
    class Vehicle
    {
        public  string brand;
        public Vehicle(string _brand)
        {
            this.brand = _brand;
        }
    }
    class Motor_Vehicle : Vehicle
    {
        public string fuel_Type;
        public Motor_Vehicle(string _brand, string fuel_Type) : base(_brand)
        {

            this.fuel_Type = fuel_Type;
        }
    }
    class Car : Motor_Vehicle
    {
        public int seating_capacity;
        public Car(string _brand,string _fuel_Type,int seating_capacity) : base(_brand, _fuel_Type)
        {
              this.seating_capacity = seating_capacity;
        }
    }
    class Truck:Motor_Vehicle
    {
        public string brake_type;
        public Truck(string _brand,string _fuel_Type, string brake_type) : base(_brand, _fuel_Type)
        {

            this.brake_type = brake_type;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Truck truck=new Truck("BMW","gaz","Disc");
                           ///sdueubuhsaefd
            Car car1 = new Car("Mercedes", "Gasoline", 5);

            Console.WriteLine("the brand of my car is:{0}\nfuel type: {1} \nand it design for {2} peopel",car1.brand,car1.fuel_Type,car1.seating_capacity);
            Console.WriteLine();
            Console.WriteLine("the brand of my truck is:{0}\nfuel type{1}\nand the type of bakes{2}",truck.brand,truck.fuel_Type,truck.brake_type);




        }
    }
}
