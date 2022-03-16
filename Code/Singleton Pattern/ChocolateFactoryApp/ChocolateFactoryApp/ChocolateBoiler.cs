using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFactoryApp
{
    public class ChocolateBoiler
    {
        private Boolean empty;
        private Boolean boiled;

        private static ChocolateBoiler _chocolateBoiler;

        public static ChocolateBoiler GetInstance()
        {
            if (_chocolateBoiler == null)
            {
                _chocolateBoiler = new ChocolateBoiler(); 
            }

            return _chocolateBoiler;

        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
    }
}
