using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures
{
    //Dictionary is a generic collection that consist elements as key value pair
    //elemewnts
    //it is not sorted order
    public class DictionaryExample
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();


        public void DictionMethod()
        {
            dictionary.Add("1","sagar");
            dictionary.Add("2", "shahu");
            dictionary.Add("3", "shreya mam");
            dictionary.Add("5", "krishana");


            Console.WriteLine("Dictionary in String and String");
            foreach (KeyValuePair<string, string> kv in dictionary)
            {
                Console.WriteLine(kv.Key+ " "+kv.Value);
            }

            Dictionary<int, string> dictionaryInt = new Dictionary<int, string>();

            dictionaryInt.Add(1 , "Pranav");
            dictionaryInt.Add(2, "Pranav");
            dictionaryInt.Add(3, "Pranav");
            //dictionaryInt[3] = "ABCD";

            if (dictionaryInt.ContainsKey(3))
            {
                dictionaryInt[3] = "Aditya";
            }

            Console.WriteLine("Dictionary in Integer and String");
            foreach (KeyValuePair<int, string> kvInt in dictionaryInt)
            {
                Console.WriteLine(kvInt.Key + " " + kvInt.Value);
            }

           
        }

        

    }
}
