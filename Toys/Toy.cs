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
            get => sentimentalValue;
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
            get => price;
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
        private double speed;
        private double height;
        private double depth;
        private int age;
        private double actualValue;
        Value basicValue;

        public double Speed { get => speed; set => speed = value; }
        public double Height { get => height; set => height = value; }
        public double Depth { get => depth; set => depth = value; }
        public int Age { get => age; set => age = value; }
        public double ActualValue { get => actualValue; set => actualValue = value; }

        public Toy(double speed, double height, double depth, int age, Value basicValue)
        {
            this.speed = speed;
            this.height = height;
            this.depth = depth;
            this.age = age;
            this.basicValue = basicValue;
            this.ActualValue = age * (basicValue.Price + basicValue.SentimentalValue);
        }
    }
}
