using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAbstractFactory
{
    public interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }
}
