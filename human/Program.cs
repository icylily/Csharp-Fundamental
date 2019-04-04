using System;
using System.Collections.Generic;

namespace human
{
//     class Human
//     {
//         // Fields for Human
//         public string Name;
//         public int Strength;
//         public int Intelligence;
//         public int Dexterity;
//         private int Health;
//         // add a public "getter" property to access health
//         public int HealthValue
//         {
//             get {return Health;}
//             set {Health = value;}
//         }
//         // Add a constructor that takes a value to set Name, and set the remaining fields to default values
//         public Human(string humanName)
//         {
//             Name = humanName;
//             Strength= 3;
//             Intelligence =3;
//             Dexterity = 3;
//             Health = 100;
//         }
//         // Add a constructor to assign custom values to all fields
//         public Human(string humanName,int strength,int intelligence,int dexterity,int health)
//         {
//             Name = humanName;
//             Strength = strength;
//             Intelligence = intelligence;
//             Dexterity = dexterity;
//             Health = health;
//         }
//         // Build Attack method
//         public int Attack(Human target)
//         {
//             int rencent_health = target.HealthValue - 5*target.Strength;
//             if (rencent_health<0)
//             {
//                 target.HealthValue=0;
//             }
//             else 
//             {
//                 target.HealthValue = rencent_health;
//             }
//             return target.HealthValue;
//         }
//     }

// //     class Food
// // {
// //     public string Name;
// //     public int Calories;
// //     // Foods can be Spicy and/or Sweet
// //     public bool IsSpicy; 
// //     public bool IsSweet; 
// //     // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
// //     public Food(string foodName,int foodCalories,bool isSpicy,bool isSweet){
// //         Name = foodName;
// //         Calories = foodCalories;
// //         IsSpicy = isSpicy;
// //         IsSweet = isSweet;
        
// //     }
// // }

    // class Ninja
    // {
    //     private int calorieIntake;
    //     public List<Food> FoodHistory;

    //     public int getCalorienInkate
    //     {
    //         get {return calorieIntake;}
    //     }


    //     // add a constructor
    //     public Ninja()
    //     {
    //         calorieIntake = 0;
    //         FoodHistory = new List<Food>();
    //     }


    //     // add a public "getter" property called "IsFull"
    //     public bool IsFull
    //     {
    //         get
    //         { 
    //             if (calorieIntake >=1200) return true;
    //             else return false;
    //         }
    //     }

    //     // build out the Eat method
    //     public void Eat(Food item)
    //     {
    //         calorieIntake += item.Calories;
    //         FoodHistory.Add(item);
    //         Console.WriteLine(item.Name + " is yummy!");
    //         if(item.IsSpicy){
    //             Console.WriteLine("It is spicy");
    //         }
    //         else{
    //             Console.WriteLine("It is not spicy at all!");
    //         }
    //     }
    // }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet serverBuffet = new Buffet();
            SweetTooth bob = new SweetTooth("Bob");
            while (!bob.IsFull){
                bob.Consume(serverBuffet.Serve());
            }
           SpiceHound jack = new SpiceHound("Jack");
            while (!jack.IsFull)
            {
                jack.Consume(serverBuffet.Serve());
            }
        }
    }
}
