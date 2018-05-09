using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            System.Threading.Thread thread1 = new System.Threading.Thread(test.Test1);
            System.Threading.Thread thread2 = new System.Threading.Thread(test.Test2);

            thread1.Start();
            thread2.Start();
        }
    }
}
