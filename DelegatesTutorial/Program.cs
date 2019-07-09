using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTutorial
{
    delegate void MDelegate();

    class DM
    {
        static public void Display()
        {
            Console.Write("Nemanja ");
        }
        static public void Print()
        {
            Console.Write("Djordjevic\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Class1 class1 = new Class1();
            //Class2 class2 = new Class2();

            MDelegate m1 = new MDelegate(DM.Display);
            MDelegate m2 = new MDelegate(DM.Print);
            MDelegate m3 = m1 + m2;
            MDelegate m4 = m2 + m1;
            MDelegate m5 = m3 - m2;
            m3();
            m4();
            m5();
        }
    }
}
