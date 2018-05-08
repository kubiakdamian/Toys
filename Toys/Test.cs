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


        public void Test1()
        {
            while (true)
            {
                toysRoom.Limit = 1000;
                Value value = new Value(7, 24);
                Toy toy = new Toy(5.1, 6.3, 7.5, 3, value);
                toysRoom.AddToy(toy);
                toysRoom.ChangeDepth(1);
                toysRoom.PrintToys();

            }
        }

        public void Test2()
        {
            while (true)
            {
                Value value = new Value(11.7, 15);
                Toy toy = new Toy(8.3, 7, 3, 5, value);
                toysRoom.AddToy(toy);
                toysRoom.ChangeHeight(2);
                toysRoom.PrintToys();


            }
        }


        public void Test3()
        {
            while (true)
            {
                Value value = new Value(70.5, 150);
                Toy toy = new Toy(5, 7.5, 2.3, 1, value);
                toysRoom.AddToy(toy);
                toysRoom.ChangeSpeed(3);
                toysRoom.PrintToys();

            }
        }
    }
}