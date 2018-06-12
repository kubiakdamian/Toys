using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    struct Value
    {
        private double price;
        private double sentimentalValue;

        public Value(double price, double sentimentalValue)
        {
            this.price = price;
            this.sentimentalValue = sentimentalValue;
        }


        public double SentimentalValue
        {
            get
            {
                return sentimentalValue;
            }
            set
            {
                if (value > 0)
                {
                    this.sentimentalValue = value;
                }
                else
                {
                    Console.WriteLine("Value must be greater than 0");
                    Console.ReadLine();
                }
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    Console.WriteLine("Price must be greater than 0");
                    Console.ReadLine();
                }
            }
        }
    }
    class Toy
    {
        private int age;
        private double actualValue;
        Value basicValue;      

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

            public double ActualValue
            {
                get
                {
                    return actualValue;
                }

                set
                {
                    actualValue = value;
                }
            }

        public Toy(int age, Value basicValue)
        {
            this.Age = age;
            this.basicValue = basicValue;
            this.ActualValue = age * (basicValue.Price + basicValue.SentimentalValue);
        }
    }
}
