using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Ball : Toy, IHasHeight
    {
        public Ball(int age, Value basicValue, double height) : base(age, basicValue)
        {
            this.Height = height;
        }

        private double height;

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
    }
}
