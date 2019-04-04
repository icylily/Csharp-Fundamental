using System;
using System.Collections.Generic;

namespace boxing_undoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxing_list = new List<object>();
            boxing_list.Add(7);
            boxing_list.Add(28);
            boxing_list.Add(-1);
            boxing_list.Add(true);
            boxing_list.Add("chair");
            int sum = 0;
            foreach(object boxing_item in boxing_list){
                Console.WriteLine("this item is "+boxing_item);
                if(boxing_item is int){
                    sum += (int)boxing_item;
                }
            }
            Console.WriteLine("The sum is "+sum);


        }
    }
}
