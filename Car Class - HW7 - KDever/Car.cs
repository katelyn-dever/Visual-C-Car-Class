using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class___HW7___KDever
{
    class Car
    {
        //Fields
        private string _make;
        private int _year;
        private double _speed;

        //Constructor
        public Car()
        {
            _make = "";
            _year = 1500;
            _speed = 0.0;
        }

        //Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //Speed property
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        //Accelerate Method
        public void Accelerate()
        {
            _speed += 5;
        }

        //Brake Method
        public void Brake()
        {
            _speed -= 5;
        }
    }
}
