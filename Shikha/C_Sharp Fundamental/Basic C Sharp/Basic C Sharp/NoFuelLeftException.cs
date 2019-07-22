using System;

namespace Vehicles
{
    class NoFuelLeftException:Exception                           //class that throw exception
    {
        public NoFuelLeftException(string strFuel)
        { Console.WriteLine(strFuel); }
    }
}
