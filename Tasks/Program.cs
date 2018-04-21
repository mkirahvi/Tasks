using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBTN();

            TestElement();
        }

        private static void TestElement() {
            var elements = new List<Element>
            {
                new Element { Age = 10, Num = 10, Name = "el1" },
                new Element { Age = 20, Num = 10, Name = "el2" },
                new Element { Age = 30, Num = 10, Name = "el3" },

                new Element { Age = 11, Num = 20, Name = "el4" },
                new Element { Age = 21, Num = 20, Name = "el5" },
                new Element { Age = 31, Num = 20, Name = "el6" },

                new Element { Age = 10, Num = 30, Name = "el7" },
                new Element { Age = 20, Num = 30, Name = "el8" },
                new Element { Age = 30, Num = 30, Name = "el9" },
            };

            var result = Element.Get(elements);

            Console.WriteLine( string.Join("\r\n", result));
        }

        private static void TestBTN()
        {
            BTN b0 = new BTN() { Val = 0 };
            BTN b1 = new BTN() { Val = 1 };
            BTN b2 = new BTN() { Val = 2 };

            BTN b401 = new BTN
            {
                Val = 4,
                Left = b0,
                Right = b1,
            };

            BTN b501 = new BTN
            {
                Val = 5,
                Left = b0,
                Right = b1,
            };

            BTN b401a = new BTN
            {
                Val = 4,
                Left = new BTN() { Val = 0 },
                Right = b1,
            };

            Console.WriteLine(b0.Equals(b1));
            Console.WriteLine(b401.Equals(b501));
            Console.WriteLine(b401.Equals(b401a));
        }
    }
}
