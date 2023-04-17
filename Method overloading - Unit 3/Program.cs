using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading___Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cellphone cellphone = new Cellphone("Samsung","Green","64 GB","High","$7 499");
            cellphone.makeCalls();
            cellphone.makeCalls("Yesenia","Armendariz");
            cellphone.makeCalls(911);
        }
    }
    public class Cellphone
    {
        protected string brand;
        protected string color;
        protected string storage;
        protected string range;
        protected string price;

        public Cellphone (string brand, string color, string storage, string range, string price)
        {
            this.brand = brand;
            this.color = color;
            this.storage = storage;
            this.range = range;
            this.price = price;
        }
        public void makeCalls()
        {
            Console.WriteLine("The cell phone can make calls");
        }
        public void makeCalls(String person)
        {
            Console.WriteLine("Call to " + person);
        }
        public void makeCalls(String person,String lastname)
        {
            Console.WriteLine("{0} {1} is calling",person,lastname);
        }
        public void makeCalls(int emergency)
        {
            Console.WriteLine("Calling 911 emergencies");
        }
    }
}
