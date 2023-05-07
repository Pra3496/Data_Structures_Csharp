
using System;
using System.Collections;


namespace Data_Structures
{
    public class ArrayListExample
    {
        ArrayList arrayList;

        public ArrayListExample()
        {
            arrayList = new ArrayList();
        }
        public void AddElement(object elements)
        {
            arrayList.Add(elements);
        }


        public void Display()
        {
            Console.WriteLine("Elements presents in ArrayList : ");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

        public void RemoveElement(object elements)
        {
            arrayList.Remove(elements);
        }




    }
}
