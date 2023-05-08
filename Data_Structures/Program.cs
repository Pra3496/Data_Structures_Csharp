using System;


namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("wellcome to ArrayList ");

            ArrayListExample arrayListExample = new ArrayListExample();

            arrayListExample.AddElement("Pranav");

            arrayListExample.AddElement("123");

            arrayListExample.AddElement(12.12);

            arrayListExample.AddElement("12");

            arrayListExample.AddElement('A');

            arrayListExample.Display();

            Console.Write("Enter the Search : ");
            object ele =(object) Console.ReadLine();
       
            arrayListExample.SearchElement(ele);
            */


            DictionaryExample example = new DictionaryExample();

            example.DictionMethod();
            Console.ReadKey();

        }
    }
}
