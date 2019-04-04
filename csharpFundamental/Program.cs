using System;

namespace csharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i<=255; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // for(int i = 1;i <=255;i++)
            // {
            //     if (((i%3 ==0)||(i%5==0))&&(!(i%15==0)))
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // for(int i=1;i<=255;i++)
            // {
            //     if(i%15==0){
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if(i%3==0){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (i%5==0){
            //         Console.WriteLine("Buzz");
            //     }
            //     else{
            //         Console.WriteLine(i);
            //     }
            // }
            int i = 1;
            while (i<=255)
            {
                // Console.WriteLine(i);
                // if (((i%3 ==0)||(i%5==0))&&(!(i%15==0)))
                // {
                //     Console.WriteLine(i);
                // }


                    if(i%15==0){
                        Console.WriteLine("FizzBuzz");
                    }
                    else if(i%3==0){
                        Console.WriteLine("Fizz");
                    }
                    else if (i%5==0){
                        Console.WriteLine("Buzz");
                    }
                    else{
                        Console.WriteLine(i);
                    }
                i++;
            }
        }
    }
}
