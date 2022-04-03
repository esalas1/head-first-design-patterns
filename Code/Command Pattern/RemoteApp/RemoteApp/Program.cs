using System;

namespace RemoteApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            RemoteControlWithUndo remote = new RemoteControlWithUndo();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            remote.SetCommand(0,lightOn, lightOff);
            remote.OnButtonWasPushed(0);
            remote.UndoButtonWasPushed();
        }
    }
}