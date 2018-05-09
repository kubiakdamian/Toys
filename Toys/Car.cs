using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Car : Toy, IHasSpeed
    {
        public Car(int age, Value basicValue, double speed) : base(age, basicValue)
        {
            this.Speed = speed;
        }

        private double speed;

        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
    }
}
