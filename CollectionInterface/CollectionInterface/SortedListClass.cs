using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace CollectionInterface
{
    class SortedListClass
    {
        SortedList sl1 = new SortedList();

        public SortedListClass()
        {
           
            sl1.Add(1, "Hrishikesh Salunkhe");
            sl1.Add(2, "Animesh Surywanshi");
            sl1.Add(3, "Rohan Salunkhe");
            sl1.Add(4, "XYZ");
            sl1.Add(5, "ABC");
            sl1.Add(6, "DEF");
        }

        public void dis()
        {
            Console.WriteLine(sl1.Count);
            Console.WriteLine(sl1.ContainsValue("XYZ"));
            Console.WriteLine(sl1.ContainsValue("PQR"));
            sl1.Remove(3);
            for (int i = 0; i < sl1.Count; i++)
            {
                       Console.WriteLine("Key :" + sl1.GetKey(i)+ "\t Value : " + sl1.GetByIndex(i));
            }
            
        }
    }
}
