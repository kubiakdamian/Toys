﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Test
    {
        private bool canAdd = true;
        ToysRoom toysRoom = new ToysRoom();
        private void ToyAddedMsg()
        {
            Console.WriteLine("Toy added");
        }
        private void ValueIncreaseMsg()
        {
            Console.WriteLine("Value increased");
        }

        private void LimitReachedMsg()
        {
            Console.WriteLine("Limit reached, press enter to exit");
            canAdd = false;
            Console.ReadLine();
            Environment.Exit(0);
        }



        public void test1()
        {
            toysRoom.onToyAdded += new ToysRoom.ToyAdded(ToyAddedMsg);
            toysRoom.onValueIncrease += new ToysRoom.ValueIncrease(ValueIncreaseMsg);
            toysRoom.onLimitReached += new ToysRoom.LimitReached(LimitReachedMsg);

            while (canAdd)
            {            
                toysRoom.Limit = 1000;
                Value value = new Value(7, 24);
                Toy toy = new Box(7, value, 8.5, 4.3);
                toysRoom.AddToy(toy);
                toysRoom.ChangeDepth(1);
                toysRoom.PrintToys();



            }
        }

        public void test2()
        {
            toysRoom.onToyAdded += new ToysRoom.ToyAdded(ToyAddedMsg);
            toysRoom.onValueIncrease += new ToysRoom.ValueIncrease(ValueIncreaseMsg);
            toysRoom.onLimitReached += new ToysRoom.LimitReached(LimitReachedMsg);

            while (canAdd)
            {
                toysRoom.Limit = 1000;
                Value value = new Value(7, 24);
                Toy toy = new Car(7, value, 115);
                toysRoom.AddToy(toy);
                toysRoom.ChangeHeight(5.7);
                toysRoom.PrintToys();
            }
        }
    }
}