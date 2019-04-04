using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            // for (int index = 0; index<numArray.Length;index++)
            // {
            //     Console.WriteLine($"numArray[{index}] is {numArray[index]}");
            // }

            string[] name =  new string[]{"Tim","Martin","Nikki","Sara"};
            // for (int index = 0; index<name.Length;index++)
            // {
            //     Console.WriteLine($"name[{index}] is {name[index]}");
            // }

            // bool[] boolArray = new bool[10];
            // for(int index = 0 ;index<boolArray.Length;index++)
            // {
            //     if(index%2==0)
            //     {
            //         boolArray[index] = true;
            //     }
            //     else{
            //         boolArray[index] = false;
            //     }
            // }
            // for (int index = 0; index < boolArray.Length; index++)
            // {
            //     Console.WriteLine($"boolArray[{index}] is {boolArray[index]}");
            // }
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("peanut butter");
            flavors.Add("cotton candy");
            flavors.Add("salted cpeanut butteraremel");
            // int count = flavors.Count;
            // Console.WriteLine($"The length of this list is  {count}");

            // Console.WriteLine($"The third item of this list is  {flavors[2]}");

            // flavors.Remove("peanut butter");
            // count = flavors.Count;
            // Console.WriteLine($"The length of this list after removed one item is  {count}");
            Dictionary<string, string> likeflavors = new Dictionary<string, string>();
            Random ran = new Random();
            foreach(string guy in name)
            {
                likeflavors.Add(guy,"");
            }

            foreach (var item in likeflavors)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            foreach(string guy in name){
                int rindex = ran.Next(0, flavors.Count - 1);
                likeflavors[guy] = flavors[rindex];
            }
            foreach (var item in likeflavors)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }



        }




    }
}

