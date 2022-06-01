using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenreicClassAssignment
{
    internal class HashtableAssignment
    {
        static void Main()
        {
            
            var myHT = new Hashtable();
            myHT.Add(0, "zero");
            myHT.Add(1, "one");
            myHT.Add(2, "two");
            myHT.Add(3, "three");
            myHT.Add(4, "four");
            foreach (DictionaryEntry entry in myHT)
            {
                Console.WriteLine($"{entry.Key}=={entry.Value}");

            }
            
            Console.WriteLine("After removing");
            myHT.Remove(1);
            foreach (DictionaryEntry de in myHT)
            {
                Console.WriteLine($"{de.Key}=={de.Value}");

            }
                
            Console.WriteLine();

            int value=4;
            Console.WriteLine("contains: {0} is {1}", value,myHT.Contains(value));
            
            

            int myKey = 2;
            Console.WriteLine("The key: {0} is {1}", myKey, myHT.ContainsKey(2));

            

            var myValue = "three";
            Console.WriteLine("The value: {0} is {1}", myValue, myHT.ContainsValue(myValue) );
            
            


           
            var myTargetArray = new String[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";

            
           
            string[] copyData = new string[myTargetArray.Length];
            Console.WriteLine("After copying the values, starting at index 6:");
            myTargetArray.CopyTo(myTargetArray, 0);

            foreach (var item in myTargetArray)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("After clonning the values");
            var output = (Array)myTargetArray.Clone();
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

       


        

        
    }
}
