using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("I am drive");
        }
    }

    class SportCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I am Drive Very Fast");
        }

    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();

            person.Drive(new SportCar()); //Methodi anuny nuynn e bayc gorcoxutyuny tarber
        }
    }
}
