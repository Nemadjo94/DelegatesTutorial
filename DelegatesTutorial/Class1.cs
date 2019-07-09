using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTutorial
{


    public partial class Class1 
    {
        delegate int Add(int x);//Signature i return type delagata mora da se poklapa sa metodama u klasi koje zelimo da pozovemo

        public Class1()
        {
            Add a = Sum; //Kreiramo instancu delegata i dodeljujemo mu vrednost metode
            Console.WriteLine(a(5).ToString());
            Console.WriteLine();
            a = Minus;//Promenom vrednosti mozemo pozivati i druge klase metode
            Console.WriteLine(a(5).ToString());
        }

        int Sum(int a)
        {
            return a + a;
        }

        int Minus(int a)
        {
            return a - a;
        }
    }
}
