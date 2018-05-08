using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class ToysRoom
    {
        List<Toy> toysList = new List<Toy>();
        private double limit;

        public double Limit { get => limit; set => limit = value; }

        public delegate void NumberToyHandler();
        public event NumberToyHandler ChangeNumber;
        private double sum = 0;

        public delegate void ValueSpeedToyHandler();
        public event ValueSpeedToyHandler ValueSpeedChange;

        public delegate void ValueHeightToyHandler();
        public event ValueHeightToyHandler ValueHeightChange;


        public delegate void ValueDepthToyHandler();
        public event ValueDepthToyHandler ValueDepthChange;


        public delegate void LimitValueToyHandler();
        public event LimitValueToyHandler LimitChange;

        public virtual void OnLimitChange()
        {
            if (LimitChange != null)
            {
                LimitChange();
            }
            else
            {
                Console.WriteLine("Price reached maximum");
                Console.ReadLine();
            }
        }



        public virtual void OnValueDepthChanged()
        {
            if (ValueDepthChange != null)
            {
                ValueDepthChange();
            }
            else
            {
                Console.WriteLine("Depth changed");
                Console.ReadLine();
            }
        }



        public virtual void OnValueHeightChanged()
        {
            if (ValueHeightChange != null)
            {
                ValueHeightChange();
            }
            else
            {
                Console.WriteLine("Heigth changed");
                Console.ReadLine();
            }
        }



        public virtual void OnValueSpeedChanged()
        {
            if (ValueSpeedChange != null)
            {
                ValueSpeedChange();
            }
            else
            {
                Console.WriteLine("Speed changed");
                Console.ReadLine();
            }
        }



        public virtual void OnToyAdded()
        {
            if (ChangeNumber != null)
            {
                ChangeNumber();
            }
            else
            {
                Console.WriteLine("Toy added");
                Console.ReadLine();
            }
        }

        public void AddToy(Toy newToy)
        {
            toysList.Add(newToy);
            OnToyAdded();
            try
            {
                if (toysList.Count > 1)
                {
                    foreach (Toy toy in toysList)
                    {
                        sum += toy.ActualValue;
                        if (limit < sum)
                        {
                            OnLimitChange();
                        }
                    }
                }
            }
            catch (System.InvalidOperationException ex)
            {

            }
        }

        public void ChangeDepth(double value)
        {
            if (toysList.Count > 1)
            {
                foreach (Toy toy in toysList)
                {
                    toy.Depth = value;
                }
                OnValueDepthChanged();
            }
        }
        public void ChangeHeight(double value)
        {
            if (toysList.Count > 1)
            {
                foreach (Toy toy in toysList)
                {
                    toy.Height = value;
                }
                OnValueHeightChanged();
            }
        }

        public void ChangeSpeed(double value)
        {
            if (toysList.Count > 1)
            {
                foreach (Toy toy in toysList)
                {
                    toy.Speed = value;
                }
                OnValueSpeedChanged();
            }
        }

        public void DeleteLastToy()
        {
            if (toysList.Count > 1)
            {
                toysList.RemoveAt(toysList.Count - 1);
                Console.WriteLine("Last Toy removed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No toys to remove");
            }
        }

        public void PrintToys()
        {
            int i = 1;

            foreach(var toy in toysList)
            {
                System.Console.WriteLine(i + "\t");
                System.Console.WriteLine("Speed: " + toy.Speed);
                System.Console.WriteLine("Height: " + toy.Height);
                System.Console.WriteLine("Depth: " + toy.Depth);
                System.Console.WriteLine("Age: " + toy.Age);
                i++;
            }

            System.Console.ReadLine();
        }

    }
}
