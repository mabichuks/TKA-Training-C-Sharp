using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    public interface ICar
    {
        void StartCar();
        void StopCar();
    }

    public interface IEngine
    {
        void StartEngine();
    }

    public interface IFuelTank
    {
        void Refuel();
    }
    public class Fuel : IFuelTank
    {
        public void Refuel()
        {
            throw new NotImplementedException();
        }
    }
    public class Engine : IEngine
    {
        private readonly IFuelTank _fuel;
        public Engine(IFuelTank fuel)
        {
            _fuel = fuel;
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }
    }
    public class Car: ICar
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartCar()
        {
            Console.WriteLine("Car started.");
        }

        public void StopCar()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    public class MyDIExample
    {
        private readonly ICar _car;

        public MyDIExample(ICar car)
        {
            _car = car;
        }
        public void MyDiMethod()
        {
            _car.StartCar();
        }
    }
}
