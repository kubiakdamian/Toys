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
        private double sum = 0;

        public delegate void ValueLimit(Toy toy, EventArgs eventArgs);
        public event ValueLimit valueLimit;

        public delegate void increaseValue(Toy toy, EventArgs eventArgs);
        public event increaseValue onIncreaseValue;

        public static void LimitReached(Object item, EventArgs eventArgs)
        {
            System.Console.WriteLine("Limit reached");
        }

        public double Limit
        {
            get
            {
                return limit;
            }

            set
            {
                limit = value;
            }
        }

        public void AddToy(Toy newToy)
        {
            toysList.Add(newToy);
            try
            {
                if (toysList.Count > 1)
                {
                    foreach (Toy toy in toysList)
                    {
                        sum += toy.ActualValue;
                        onIncreaseValue(toy, new EventArgs());
                        if(onIncreaseValue != null)
                        {
                            onIncreaseValue.Invoke(toy, new EventArgs());
                        }     

                        if (Limit < sum)
                        {
                            valueLimit(toy, new EventArgs());
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
                    if(toy is IHasDepth)
                    {
                        IHasDepth temp = (IHasDepth)(toy);
                        temp.Depth = value;
                    }
                    
                }
            }
        }
        public void ChangeHeight(double value)
        {
            if (toysList.Count > 1)
            {
                foreach (Toy toy in toysList)
                {
                    if (toy is IHasHeight)
                    {
                        IHasHeight temp = (IHasHeight)(toy);
                        temp.Height = value;
                    }            
                }
            }
        }

        public void ChangeSpeed(double value)
        {
            if (toysList.Count > 1)
            {
                foreach (Toy toy in toysList)
                {
                    if (toy is IHasSpeed)
                    {
                        IHasSpeed temp = (IHasSpeed)(toy);
                        temp.Speed = value;
                    }
                }
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
                printSpeed(toy);
                printHeight(toy);
                printDepth(toy);
                System.Console.WriteLine("Age: " + toy.Age);
                i++;
            }

            System.Console.ReadLine();
        }

        private void printSpeed(Toy toy)
        {
            if (toy is IHasSpeed)
            {
                IHasSpeed temp = (IHasSpeed)(toy);
                System.Console.WriteLine("Speed: " + temp.Speed);
            }
        }

        private void printHeight(Toy toy)
        {
            if (toy is IHasHeight)
            {
                IHasHeight temp = (IHasHeight)(toy);
                System.Console.WriteLine("Height: " + temp.Height);
            }
        }

        private void printDepth(Toy toy)
        {
            if (toy is IHasDepth)
            {
                IHasDepth temp = (IHasDepth)(toy);
                System.Console.WriteLine("Depth: " + temp.Depth);
            }
        }

    }
}
