using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    internal class Program
    {
        static void UseList()
        {
            List<int> ints = new List<int>();
            ArrayList al = new ArrayList();
            //pass the value
            al.Add(1);
            //pass the index and the value, where index<=number of elements currently present
            al.Insert(0, 2);
            //pass the value to remove
            al.Remove(1);
            //pass the index position of the value to remove
            al.RemoveAt(0);

            //capacity of the list
            //al.Capacity

            //number of elements currently present
            //al.Count 
        }
        static void UseStack()
        {
            //LIFO
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Pop();
        }
        static void UseQueue()
        {
            //FIFO
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);

            q.Dequeue();
        }
        static void UseMap()
        {
            //NO DUPLICATE KEY

            //collection
            Hashtable ht = new Hashtable();
            ht.Add(1, "siemens");
            ht.Add('a', 12.34m);
            ht.Add("str", 12);
            //ht.Add('a', false);<--exception
            ht['a'] = false; //<-- the value will be updated, in case the same key exsists or the key with the value will be added if the key does not exist

            //pass the key
            //ht.Remove(1);
            Console.WriteLine("\nhash table\n");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //remember: the keys must be of similar type in order for them to be sorted
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "siemens");
            sortedList.Add(0, 12.34m);
            sortedList.Add(2, 12);
            //sortedList.Add(0, false);<--exception
            sortedList[0] = false; //<-- the value will be updated, in case the same key exsists or the key with the value will be added if the key does not exist

            //pass the key
            //sortedList.Remove(1);
            Console.WriteLine("\nsorted list\n");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //generic
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "siemens");
            keyValuePairs.Add(0, "bangalore");
            keyValuePairs.Add(2, "Joydip");
            //keyValuePairs.Add(0, ""); <-- exception
            keyValuePairs[0] = "Bengaluru"; //<-- the value will be updated, in case the same key exsists or the key with the value will be added if the key does not exist

            //pass the key
            // keyValuePairs.Remove(1);

            Console.WriteLine("\ndictionary\n");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            SortedList<int,string> keysValues = new SortedList<int,string>();
            keysValues.Add(1, "siemens");
            keysValues.Add(0, "bangalore");
            keysValues.Add(2, "Joydip");
            //keysValues.Add(0, ""); <-- exception
            keysValues[0] = "Bengaluru"; //<-- the value will be updated, in case the same key exsists or the key with the value will be added if the key does not exist

            //pass the key
            // keysValues.Remove(1);

            Console.WriteLine("\ngeneric sorted list\n");
            foreach (KeyValuePair<int, string> item in keysValues)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
        static void Main()
        {
            UseMap();
        }
    }
}
