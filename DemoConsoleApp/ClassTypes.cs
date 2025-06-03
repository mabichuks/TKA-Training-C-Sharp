using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public static class Engine
    {
        public static string EngineModel { get; set; } = "V6"; // Static property for the engine model
    }

    public static class Car
    {

        public static string Name { get; set; }
        public static string Color { get; set; }
    }

    //access modifier //static or instance (empty when instance) //return type //name //parameters
    public class MyClassDemo
    {
        public static int MyMethod(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
