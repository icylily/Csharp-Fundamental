using System;
using System.Collections.Generic;
class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if (IsFull)
        {
            Console.WriteLine($"{Name} was already full,can not consume anymore!");
        }
        else
        {
            calorieIntake += item.Calories;
            if (item.IsSpicy)
            {
                calorieIntake -= 10;
            }
            ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());
           
        }

    }
    public override bool IsFull
    {
        get
        {
            if (calorieIntake >= 1200) return true;
            else return false;
        }
    }
    

    public SpiceHound(string name):base(name){}
}