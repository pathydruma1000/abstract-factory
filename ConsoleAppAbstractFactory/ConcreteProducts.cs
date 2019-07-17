using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAbstractFactory
{
    //concrete product X1
    public class HondaCompactSedan : ISedan
    {
        public string Name()
        {
            return "Honda Amaze";
        }
    }

    //concrete product X2
    public class HondaFullSedan : ISedan
    {
        public string Name()
        {
            return "Honda Accord";
        }
    }

    //concrete product Y1
    public class HondaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Honda CR-V";
        }
    }

    //concrete product Y2
    public class HondaFullSuv : ISuv
    {
        public string Name()
        {
            return "Honda Pilot";
        }
    }

    //concrete product X11
    public class ToyotaCompactSedan : ISedan
    {
        public string Name()
        {
            return "Toyota Yaris";
        }
    }

    //concrete product X12
    public class ToyotaFullSedan : ISedan
    {
        public string Name()
        {
            return "Toyota Camry";
        }
    }

    //concrete product Y11
    public class ToyotaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Toyota Rav-4";
        }
    }

    //concrete product Y12
    public class ToyotaFullSuv : ISuv
    {
        public string Name()
        {
            return "Toyota Highlander";
        }
    }
}
