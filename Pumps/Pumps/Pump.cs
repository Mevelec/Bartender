using System;
using System.Collections.Generic;
using System.Text;
using System.Device.Gpio;
using System.Threading;

namespace Pumps
{
    public abstract class Pump : Logic.IPump
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string pin { get; set; }

        protected PumpsTypes type = PumpsTypes.Default;

        public bool pump(float qty)
        {
            //* https://github.com/dotnet/iot/blob/master/samples/led-blink/README.md *//
            Console.WriteLine("Light Led");
            //int pin = 17;
            GpioController controller = new GpioController();/*
            controller.OpenPin(pin, PinMode.Output);
            int lightTimeInMilliseconds = (int)qty;
            int dimTimeInMilliseconds = 200;

            while (true)
            {
                Console.WriteLine($"Light for {lightTimeInMilliseconds}ms");
                controller.Write(pin, PinValue.High);
                Thread.Sleep(lightTimeInMilliseconds);
                Console.WriteLine($"Dim for {dimTimeInMilliseconds}ms");
                controller.Write(pin, PinValue.Low);
                Thread.Sleep(dimTimeInMilliseconds);
            }
            */
            return false;
        }
    }
}
