using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new CarContext())
            {

                //Person person = new Person
                //{
                //    Name = "Denis"
                //};

                //context.Persons.Add(person);
                //context.SaveChanges();
                //Car car = new Car
                //{
                //    LicenceNumber = "sgsgs",
                //    Year = 2017,
                //    Person = context.Persons.First()
                //};
                //context.Cars.Add(car);
                //context.SaveChanges();
                var cars = context.Cars.ToArray();
                var persons = context.Persons;
                //Console.WriteLine($"We have {cars.Length} car(s).");
                foreach(var el in cars)
                {
                    Console.WriteLine("Number: {0}  Year: {1}", el.LicenceNumber, el.Year);
                }
                foreach (var el in persons)
                {
                    Console.WriteLine("Name: {0}  FirstCar: {1}", el.Name, el.Cars.First().LicenceNumber);
                }
                Console.Read();
            }
        }
    }
}
