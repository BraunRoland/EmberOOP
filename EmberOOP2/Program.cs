using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e1 = new Ember("Jancsi", 1860, 120);
            Ember e2 = new Ember("Julcsika", 1858, 121);
            Console.WriteLine(e1.Nev);
            Console.WriteLine(e2.Nev);
            e1.Nev = "János";
            Console.WriteLine(e1.Nev);
            Console.WriteLine($"{e1.Nev} eletkora: {e1.Eletkor}");
            Console.WriteLine($"{e1.Nev} eletkora: {e1.EletkorMetodus()}");
            Ember e3 = new Ember("Elemér", 50);
            Console.WriteLine(e3);
            Ember e4 = new Ember(48);
            Console.WriteLine(e4);
        }
    }
}
