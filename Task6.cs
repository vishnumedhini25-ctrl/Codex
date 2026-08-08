using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_2
{
    class Program2
    {
        static void Main (string [] args)
        {
            

            //Arraylist

            ArrayList arraylist = new ArrayList();

            arraylist.Add("Medhini");
            arraylist.Add(888);
            arraylist.Add("A");
            arraylist.Add(5.57);

            for (int m = 0; m < arraylist.Count; m++)
            {
                Console.WriteLine(arraylist[m]);
            }
            Console.ReadLine();

            //List

            List<int> empId = new List<int>();
            empId.Add(101);
            empId.Add(102);
            empId.Add(103);
            empId.Add(104);

            foreach(int id in empId)
            {
                Console.WriteLine("Employee ID :" + id);

            }
            Console.ReadLine();

            //Hashtable

            Hashtable Table = new Hashtable();
            Table.Add("01", "Rakesh");
            Table.Add("02", "Ram");
            Table.Add("03", "Rita");
            Table.Add("04", "Revathy");

            foreach(var items in Table.Keys)
            {
                Console.WriteLine(Table[items]);
            }
            Console.ReadLine();

            //SortedList

            SortedList list = new SortedList();
            list.Add(1, "sea");
            list.Add(2, "ocean");
            list.Add(3, "waves");
            list.Add(4, "shell");

            foreach(var values in list.Keys)
            {
                Console.WriteLine(list[values]);
            }
            Console.ReadLine();





        }

    }
}
