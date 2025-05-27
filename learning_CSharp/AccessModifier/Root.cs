using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.AccessModifier
{
    public class Car
    {
        public string brand = "Toyota";
        private string engineNumber = "ABC123";
        protected string type = "Bus";

        public void ShowEngine()
        {
            Console.WriteLine(engineNumber); // ঠিক আছে
        }
    }

    internal class Engine
    {
        internal string model = "V8";
    }

    public class Bus : Car
    {
        public void Display()
        {
            Console.WriteLine(type); // ✔️ ইনহেরিটেড ক্লাসে অ্যাক্সেসযোগ্য
        }
    }

    public class Machine
    {
        protected internal string status = "Running";
    }

    public class Generator : Machine
    {
        public void PrintStatus()
        {
            Console.WriteLine(status); // ✔️ ইনহেরিটেড এবং একই অ্যাসেম্বলি
        }
    }

    public class Device
    {
        private protected string id = "Device001";
    }

    public class Laptop : Device
    {
        public void ShowId()
        {
            Console.WriteLine(id); // ✔️ ঠিক আছে, কারণ ইনহেরিটেড এবং একই অ্যাসেম্বলি
        }
    }



    public class Root
    {
        public Root()
        {
            //public
            Car car = new Car();
            Console.WriteLine($"Car brand: {car.brand}");

            //private
            //car.engineNumber; // ত্রুটি: 'Car.engineNumber' অ্যাক্সেসযোগ্য নয় কারণ এটি 'private' অ্যাক্সেস মডিফায়ার দ্বারা চিহ্নিত করা হয়েছে
            car.ShowEngine(); // ঠিক আছে

            //protected
            Bus bus = new Bus();
            bus.Display(); // ✔️ ইনহেরিটেড ক্লাসে অ্যাক্সেসযোগ্য
                           //car.type = "Truck"; // ত্রুটি: 'Car.type' অ্যাক্সেসযোগ্য নয় কারণ এটি 'protected' অ্যাক্সেস মডিফায়ার দ্বারা চিহ্নিত করা হয়েছে

            // internal
            Engine engine = new Engine();
            Console.WriteLine(engine.model); // ✔️ ঠিক আছে যদি একই অ্যাসেম্বলি/প্রজেক্টে থাকে

            // protected internal
            Generator gen = new Generator();
            Console.WriteLine(gen.status); // ✔️ একই অ্যাসেম্বলি হওয়ায় অ্যাক্সেসযোগ্য

            // private protected
            Laptop myLaptop = new Laptop();
            myLaptop.ShowId(); // ✔️ ইনহেরিটেড এবং একই অ্যাসেম্বলি হওয়ায় অ্যাক্সেসযোগ্য
        }
    }
}
