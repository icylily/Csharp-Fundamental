using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] randomArray = new int[10];
            Random rand = new Random();
            randomArray[0] = rand.Next(5, 25);
            int min= randomArray[0];
            int max = randomArray[0];
            int sum = randomArray[0];
            // int max = randomArray[0];
            for(int i=1;i<10;i++){
                randomArray[i] = rand.Next(5,25);
                if (min>randomArray[i]){
                    min = randomArray[i];
                }
                if(max<randomArray[i]){
                    max = randomArray[i];
                }
                sum+= randomArray[i];
            }
            foreach(int num in randomArray){
                Console.Write(num+" ");
            }
            Console.WriteLine("min is "+min);
            Console.WriteLine("max is "+max);
            Console.WriteLine("sum is  "+sum);
            return randomArray;
        }

        public static string TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int rand_num = rand.Next(1,100);
            if(rand_num%2==0){
                return "Heads";
            }
            else{
                return "Tails";
            }
        }

        public static double TossMultipleCoins(int num){
            int head=0;
            for(int i = 0; i<num;i++){
                if(TossCoin()=="Heads"){
                    head++;
                }
            }
            return (double)head/(double)num;
        }
        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            string tmp="";
            Random rand = new Random();
            for(int i=0;i<names.Count;i++){
                int rand_index = rand.Next(0,names.Count-1);
                tmp =  names[i];
                names[i] = names[rand_index];
                names[rand_index]=tmp;
            }
            foreach(string name in names){
                Console.WriteLine(name+" ");
            }
            for(int i=names.Count-1;i>=0;i--){
                if(names[i].Length<5){
                    names.Remove(names[i]);
                }
            }
            return names;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // RandomArray();
            // Console.WriteLine(TossMultipleCoins(1000));
            List<string> names = Names();
            foreach(string name in names){
                Console.Write(name+" ");
            }
        }
    }
}
