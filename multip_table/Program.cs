using System;

namespace multip_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multip_array = new int[10,10];
            for(int i=1;i<=10;i++){
                for (int j = 1;j<=10;j++){
                    multip_array[i-1,j-1] = i*j;

                }
            }

            for(int i=0;i<10;i++){
                for(int j=0;j<10;j++){
                    Console.Write(multip_array[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

        }


    }
}
