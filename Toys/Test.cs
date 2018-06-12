using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Test
    {
        ToysRoom toysRoom = new ToysRoom();
        private void ToyAddedMsg()
        {
            Console.WriteLine("Toy added");
        }
        private void ValueIncreaseMsg()
        {
            Console.WriteLine("Value increased");
        }



        public void Test1()
        {
            while (true)
            {            
                toysRoom.Limit = 1000;
                Value value = new Value(7, 24);
                Toy toy = new Box(7, value, 8.5, 4.3);
                toysRoom.AddToy(toy);
                toysRoom.ChangeDepth(1);
                toysRoom.PrintToys();
                toysRoom.onToyAdded += new ToysRoom.ToyAdded(ToyAddedMsg);
                toysRoom.onValueIncrease += new ToysRoom.ValueIncrease(ValueIncreaseMsg);
            }
        }

        public void Test2()
        {
            while (true)
            {
                Value value = new Value(11.7, 15);
                Toy toy = new Car(5, value, 17);
                toysRoom.AddToy(toy);
                toysRoom.ChangeSpeed(100);
                toysRoom.PrintToys();
            }
        }

        public void Test3()
        {
            while (true)
            {
                Value value = new Value(8.7, 12.4);
                Toy toy = new Ball(5, value, 2.5);
                toysRoom.AddToy(toy);
                toysRoom.ChangeHeight(2);
                toysRoom.PrintToys();
            }
        }
    }
}