
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



        public void SearchElement(object element)
        {
            int i = 0;
            for (i = 0; i < arrayList.Count; i++)
            {

                if (arrayList.Contains(element))
                {
                    Console.WriteLine("Present in List" + arrayList[i]);
                    break;
                }
            }
            if (i == arrayList.Count)
            {
                Console.WriteLine("Not Present in List ");
            }

        }

    }
}
