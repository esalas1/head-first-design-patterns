using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public class GarageDoor
    {
        Light light;

        public GarageDoor(Light light)
        {
            this.light = light;
        }


        public void Up()
        {
            Console.WriteLine("Garage door opened.");
        }

        public void Down()
        {
            Console.WriteLine("Garage door closed.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door was stopped.");
        }

        public void LightOn()
        {
            Console.WriteLine("Light was turned on.");
        }

        public void LightOff()
        {
            Console.WriteLine("Light was turned off.");
        }
    }
}
