using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Box : Toy, IHasDepth, IHasHeight
    {
        public Box(int age, Value basicValue, double depth, double height) : base(age, basicValue)
        {
            this.Depth = depth;
            this.Height = height;
        }

        private double depth;
        private double height;

        public double Depth
        {
            get
            {
                return depth;
            }

            set
            {
                depth = value;
            }
        }

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
