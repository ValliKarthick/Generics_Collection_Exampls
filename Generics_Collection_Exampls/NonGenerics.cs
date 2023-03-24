using System;
using System.Collections;

namespace Generics_Collection_Exampls
{
    public class NonGenerics
    {
        public void PerformArrayListOperations()
        {
            //ArrayList random = new ArrayList();
            //random.Add("LTI");
            //random.Add("@#$");
            //random.Add(56.67f);
            //random.Add(false);
            //random.Add("welcome");
            //Console.WriteLine("The list of items");
            //foreach (var item in random)
            //{
            //    Console.WriteLine(item);
            //}

            //random.Insert(2, "Chocolate");
            //Console.WriteLine("Count: " + random.Count);
            //Console.WriteLine("Capacity: " + random.Capacity);
            //random.RemoveAt(3);
            ////random.Sort();
            //Console.WriteLine("Modified List");

            //foreach (var item in random)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList numberList = new ArrayList();
            //numberList.Add(10);
            //numberList.Add(40);
            //numberList.Add(50);
            //numberList.Add(30);
            //numberList.Add(20);
            //numberList.Sort();
            ////numberList.Insert(3, 30);
            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public void PerformHashTableOperations()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("one", "oracle");
            hashTable.Add(1, "vb.net");
            hashTable.Add("I", "cs.net");
            hashTable.Add("asp", "asp.net");

            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
    }
}
