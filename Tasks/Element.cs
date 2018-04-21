using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    class Element
    {
        int num;
        String name;
        int age;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public int Num { get => num; set => num = value; }

        public override string ToString()
        {
            return $"{Num}: Age {age} Name {Name}";
        }
        public static ICollection<Element> Get(ICollection<Element> elements)
        {
            return
                elements
                    .Where(x => x.age > 20)
                    .GroupBy(x => x.num)
                    .Select(x => x.First())
                    .ToList();
        }
    }

    //    please implement method taking Collection<Element> as an argument and returning Collection<Element> 
    // where all elements are unique by "num" and age>20. In case of ambiguity, put in target collection any of input elements.

}
