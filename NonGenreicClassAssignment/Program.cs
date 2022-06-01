using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenreicClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList mySL = new SortedList();
            mySL.Add("one", "The");
            mySL.Add("two", "quick");
            mySL.Add("three", "brown");
            mySL.Add("four", "fox");

            String[] temArray = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
            DictionaryEntry[] myTargetArray = new DictionaryEntry[15];
            int i = 0;
            foreach (string s in temArray)
            {
                myTargetArray[i].Key = i;
                myTargetArray[i].Value = s;
                i++;
            }

            Console.WriteLine("The SortedList contains the following:");
            var iterate = mySL.GetEnumerator();
            IDictionaryEnumerator vs = mySL.GetEnumerator();//correct
            while (iterate.MoveNext())
            {
                Console.WriteLine($"{iterate.Key} == {iterate.Value}");
            }





            SortedList my_slist = new SortedList();

            // Adding key/value pairs in
            // SortedList using Add() method
            my_slist.Add(1.02, "This");
            my_slist.Add(1.07, "Is");
            my_slist.Add(1.04, "SortedList");
            my_slist.Add(1.01, "Tutorial");

            // Using Contains() method to check
            // the specified key is present or not
            if (my_slist.Contains(1.02) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsKey() method to check
            // the specified key is present or not
            if (my_slist.ContainsKey(1.03) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsValue() method to check
            // the specified value is present or not
            if (my_slist.ContainsValue("Is") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }




            SortedList list = new SortedList();

           
            list.Add(1.02, "This");
            list.Add(1.07, "Is");
            list.Add(1.04, "SortedList");
            list.Add(1.01, "Tutorial");

            foreach (DictionaryEntry pair in list)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

           
            list.Remove(1.07);

            // After Remove() method
            foreach (DictionaryEntry pair in list)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

            // Remove element at index 2
            my_slist.RemoveAt(2);

            // After RemoveAt() method
            foreach (DictionaryEntry pair in list)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

           
            list.Clear();
            Console.WriteLine("The total number of key/value pairs" +
                        " present in my_slist:{0}", list.Count);
        }
    }
}
