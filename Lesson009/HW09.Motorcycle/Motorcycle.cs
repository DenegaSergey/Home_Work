using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    class Motorcycle
    {
        private string _model;
        private string _make;
        private DateTime _createdAt;
        private string _condition;
        private int _mileage;
        private string _motorcycleType;
        private string _exteriorColor;

        public string Model => _model;
        public string Make => _make;
        public DateTime CreatedAt => _createdAt;
        public string Condition => _condition;
        public int Mileage => _mileage;
        public string MotorcycleType => _motorcycleType;
        public string ExteriorColor => _exteriorColor;

        public Motorcycle(string model, string make, DateTime createdAt, string condition, int mileage, string motorcycleType, string exteriorColor)
        {
            this._model = model;
            this._make = make;
            this._createdAt = createdAt;
            this._condition = condition;
            this._mileage = mileage;
            this._motorcycleType = motorcycleType;
            this._exteriorColor = exteriorColor;
        }

        public string GetAllInfo()
        {
            var createdAt = "";
            createdAt += _createdAt;

            Console.WriteLine($"{"Model:",-20} |{_model}");
            Console.WriteLine($"{"Make:",-20} |{_make}");
            Console.WriteLine($"{"CreatedAt:",-20} |{_createdAt}");
            Console.WriteLine($"{"Condition:",-20} |{_condition}");
            Console.WriteLine($"{"Mileage:",-20} |{_mileage}");
            Console.WriteLine($"{"MotorcycleType:",-20} |{_motorcycleType}");
            Console.WriteLine($"{"ExteriorColor:",-20} |{_exteriorColor}");
            return null;
        }
    }
}
