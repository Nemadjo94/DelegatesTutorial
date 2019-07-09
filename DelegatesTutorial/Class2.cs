using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTutorial
{
    class Class2
    {
        //Multicast delegat
        delegate void Add(int x);

        public Class2()
        {
            Add a = Sum;//Sada se pozivanjem objekta delegata izvrsavaju se obe metode
            a += Minus;
            a(5);
        }

        void Sum(int a)
        {
            Console.WriteLine(a + a);
        }

        void Minus(int a)
        {
            Console.WriteLine(a - a);
        }
    }
}
