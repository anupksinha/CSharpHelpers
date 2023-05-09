using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelpers.Helpers
{
    public static class CollectionsHelper
    {
        public static void CreateAndDisplayArray()
        {
            int[] arr = new int[10];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            arr[4] = 5;
            arr[5] = 6;
            arr[6] = 7;

            arr[7] = 8;
            arr[8] = 9;

            arr[9] = 10;                       

            foreach(int i in arr) { System.Console.WriteLine(i); }  
        }

        public static void CreateAndDisplayArrayList()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Two");
            arrList.Add(3);

            foreach(var i in arrList) { System.Console.WriteLine(i);}
        }

        public static void CreateAndDisplayHashTable()
        {

            Hashtable myHash = new Hashtable();
            myHash.Add("a", 1);
            myHash.Add("b", 2);
            myHash.Add("c", "Three");

            foreach (DictionaryEntry item in myHash)    
            {
                System.Console.WriteLine($"{item.Key}, {item.Value}");
            }

        }

        public static void CreateAndDisplayDictionary()
        {
            Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs.Add("a", 1);
            keyValuePairs.Add("b", 2);
            keyValuePairs.Add("c", 3);

            foreach (KeyValuePair<string,int> item in keyValuePairs)
            {
                System.Console.WriteLine($"{item.Key} , {item.Value} ");
            }
                
        }

        public static void CreateAndDisplayQueue()
        {
            Queue<String> queue = new Queue<String>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");

            foreach(var item in queue)
            {
                System.Console.WriteLine(item);
            }

        }

        public static void CreateAndDisplayStack()
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);



            foreach (var item in stack)
            { System.Console.WriteLine(item); }

        }

        public static void CreateAndDisplayList()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            foreach(var item in list)
            { System.Console.WriteLine($"{item.ToString()}");}

        }





    }
}
