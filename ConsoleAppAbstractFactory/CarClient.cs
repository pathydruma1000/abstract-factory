using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAbstractFactory
{
    public class CarClient
    {
        private ISedan sedan;
        private ISuv suv;

        public CarClient(ICarFactory factory, string segment)
        {
            sedan = factory.ManufactureSedan(segment);
            suv = factory.ManufactureSuv(segment);
        }

        public string GetManufacturedSedanName()
        {
            return sedan.Name();
        }

        public string GetManufacturedSuvName()
        {
            return suv.Name();
        }
    }
}
