using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task1
{
    internal class Car
    {
        private string _make;
        private string _model;
        private int _currentSpeed;
        private double _engineSize;

        public string Make
        {
            get { return _make; }
            set { }
        }
        public string Model
        {
            get { return _model; }
            set { }
        }
        public int CurrentSpeed
        {
            get { return _currentSpeed; }
            set { }
        }
        public double EngineSize
        {
            get { return _engineSize; }
            set { }
        }

        public Car (string make, string model, int currentSpeed, double engineSize)
        {
            this._make = make;
            this._model = model;
            this._currentSpeed = currentSpeed;
            this._engineSize = engineSize;
        }
        public void Accelerate()
        {
            _currentSpeed += 10;
            Console.WriteLine($"Current Speed is: {this._currentSpeed}");
        }
        
        public void DisplayCarInfo()
        {
            Console.WriteLine($"\nMake: {this._make}");
            Console.WriteLine($"Model: {this._model}");
            Console.WriteLine($"Engine Size: {this._engineSize} L");
            Console.WriteLine($"Current Speed: {this._currentSpeed} km/h\n");
        }

        public override string ToString()
        {
            return $"Make: {this._make}, Model: {this._model}, Current Speed: {this._currentSpeed}, Engine size: {this._engineSize}";
        }
    }
}
