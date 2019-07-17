using System;

namespace ConsoleAppAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClient hondaClient;
            CarClient toyotaClient;
            Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
            hondaClient = new CarClient(new HondaFactory(), "compact");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSedanName() + " as compact Sedan");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSuvName() + " as compact SUV");

            hondaClient = new CarClient(new HondaFactory(), "full");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSedanName() + " as full Sedan");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSuvName() + " as full SUV");

            Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
            toyotaClient = new CarClient(new ToyotaFactory(), "compact");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSedanName() + " as compact Sedan");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSuvName() + " as compact SUV");

            toyotaClient = new CarClient(new ToyotaFactory(), "full");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSedanName() + " as full Sedan");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSuvName() + " as full SUV");
            Console.ReadLine();


            /*
             ------------This is HONDA Car Factory----------------

             Manufactureing Honda Amaze as compact Sedan

             Manufactureing Honda CR-V as compact SUV

             Manufactureing Honda Accord as full Sedan

             Manufactureing Honda Pilot as full SUV


            ------------This is TOYOTA Car Factory----------------

             Manufactureing Toyota Yaris as compact Sedan

             Manufactureing Toyota Rav-4 as compact SUV

             Manufactureing Toyota Camry as full Sedan

             Manufactureing Toyota Highlander as full SUV

             */

        }
    }
}
