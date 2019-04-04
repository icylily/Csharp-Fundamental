using System;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i=1;i<=255;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i=1;i<=255;i++)
            {
                if(i%2!=0){
                    Console.WriteLine("get an odd number: " +i);
                }
            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach(int num in numbers){
                Console.WriteLine("this num is:"+ num);
            }
        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for(int i = 0 ;i <=255;i++){
                sum+=i;
                Console.WriteLine("New number: "+i+ " Sum: " +sum);
            }
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            for (int index = 1;index<numbers.Length;index++){
                if (max<numbers[index]){
                    max=numbers[index];
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0 ;
            foreach(int num in numbers){
                sum+=num;
            }
            float ave = (float)sum /(float)numbers.Length;
            Console.WriteLine("The sum of this array is  " + sum);
            Console.WriteLine("The length of this array is  " + numbers.Length);
            Console.WriteLine("The average of this array is  "+ave);
        }
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] oddArray = new int[255/2 +1];
            int j=0;
            for (int i=1;i<=255;i++){
                if(i%2!=0){
                    oddArray[j]=i;
                    j++;
                }
            }
            return oddArray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int  result = 0 ;
            foreach(int num in numbers){
                if(num>y){
                    result++;
                }
            }
            Console.WriteLine("There are "+ result+" numbers greater then "+y);
            return result;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(int i=0;i<numbers.Length;i++){
                numbers[i]=numbers[i]*numbers[i];
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
               if(numbers[i]<0){
                   numbers[i]=0;
               }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int sum = numbers[0];
            for (int i = 1; i<numbers.Length;i++){
                if(max<numbers[i]){
                    max = numbers[i];
                }
                if(min > numbers[i]){
                    min = numbers[i];
                }
                sum+=numbers[i];
            }
            float ave = (float)sum / (float)numbers.Length;
            Console.WriteLine("max is  "+max);
            Console.WriteLine("min is "+min);
            Console.WriteLine("ave is  "+ave);
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for(int i = 1;i<numbers.Length;i++){
                numbers[i-1]=numbers[i];
            }
            numbers[numbers.Length-1]=0;
            foreach(int num in numbers){
                Console.Write(num);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            int length =  numbers.Length;
            object[] newArray= new object[length];
            for(int i=0;i<length;i++){
                if(numbers[i]<0){
                    newArray[i]="Dojo";
                }
                else{
                    newArray[i]=numbers[i];
                }
            }
            foreach(var item in newArray){
                Console.Write(item);
            }
            return newArray;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // PrintSum();
            int[] numArray = new int[]{1,2,-3,6,7,-8};
            // LoopArray(numArray);
            // int max = FindMax(numArray);
            // Console.WriteLine("Max value is " +max);
            // GetAverage(numArray);
            // int[] oddArray =OddArray();
            // foreach(int num in oddArray){
            //     Console.WriteLine(num);
            // }
            // GreaterThanY(numArray,3);
            // EliminateNegatives(numArray);
            // foreach(int num in numArray){
            //     Console.Write(num);
            // }
            // MinMaxAverage(numArray);
            // ShiftValues(numArray);
            NumToString(numArray);

        }
    }
}
