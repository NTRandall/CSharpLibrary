using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {Vin = "123", Make = "Honda", Model = "Accord", Price = 4300, Year = 1999 },
                new UsedCar() {Vin = "1234", Make = "Honda", Model = "Civic", Price = 6000, Year = 2009 },
                new UsedCar() {Vin = "12345", Make = "Acura", Model = "TL", Price = 9000, Year = 2008 },
                new UsedCar() {Vin = "123456", Make = "Acura", Model = "RL", Price = 10000, Year = 2010 },
                new UsedCar() {Vin = "123566", Make = "Toyota", Model = "Rav4 EV", Price = 18900, Year = 2012 },
                new UsedCar() {Vin = "123453", Make = "Toyota", Model = "Rav4", Price = 14000, Year = 2015 },
                new UsedCar() {Vin = "123566", Make = "Hyundai", Model = "Elantra", Price = 8000, Year = 2006 },
                 new UsedCar() {Vin = "234", Make = "BMW", Model = "300i", Price = 9999, Year = 1986 },
                new UsedCar() {Vin = "4524", Make = "BMW", Model = "740", Price = 32000, Year = 2017 },
            };
            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine( "Here are the vehicles you requested {0} {1} {2:C}", bmw.Year,bmw.Model,bmw.Price);
             
            }

            Console.WriteLine("===================");
            var cheapCars = from car in usedCars
                       where car.Price < 20000 && car.Price > 5000 && car.Make == "Toyota"
                       select car;
            foreach (var cheapCar in cheapCars)
            {
                Console.WriteLine("Here are the vehicles you requested {0} {1} {2:C}",
                    cheapCar.Year,
                    cheapCar.Model, 
                    cheapCar.Price);
                
            }

            Console.WriteLine("===============================");
            Console.WriteLine("LINQ with Lamda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in toyotas)
            {
                Console.WriteLine(toyota.Model);
            }

            Console.WriteLine("===============================");
            var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Model == "Toyota" || car.Make=="BMW");
            foreach (var niceUsedCar in niceUsedCars)
            {
                Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.Price);
            }
            Console.WriteLine("Devan's Solution to Kenn's Challenge");
            Console.WriteLine("Please enter an amount you would like to spend");
            int input = Int32.Parse(Console.ReadLine());

            var userCar = usedCars.Where(car => car.Price > input);
            foreach (var car in userCar)
            {
                Console.WriteLine("These vehicles are available for less than {0:C}: {1} {2} {3}",
                    input, car.Year, car.Make, car.Model);
            }
            Console.ReadLine();
        }


        class UsedCar
        {
            public string Vin { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
            
        }

    }

}
