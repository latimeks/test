using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Concept_practice
{
    class Acct
    {
        // Auto-implemented property
        public string Title { get;  set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int a = 4;
            int b;
            Console.WriteLine($"The entered string is {name}");

            Acct t = new Acct();
            t.Title = "Rock";
            Console.WriteLine($"The title is {t.Title}");

            Console.WriteLine($"OG A val: {a}");
            Console.WriteLine($"OG B val is uninitalized");

            SquareByRef(ref a); // passes a refference  in and modifies the return
            SquareByOut(out b); // passes a refference  in as an output, assigns a value, modifies it and thus returns implicitly

            Console.WriteLine($"After special square A val: {a}");
            Console.WriteLine($"After special square B val: {b}");

            Square(a);
            Square(b);

            Console.WriteLine($"After normal square A val: {a}");
            Console.WriteLine($"After normal square B val: {b}");

            Console.ReadKey();

        }

        static void SquareByRef(ref int x)
        {
            x = x * x;
        }

        static void SquareByOut(out int x)
        {
            x = 2;
            x = x * x;
        }

        static void Square(int x)
        {
            x = x * x;
        }
    }
}
