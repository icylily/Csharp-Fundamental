using System;
using System.Collections.Generic;
class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if(IsFull)
        {
            Console.WriteLine($"{Name} was already full,can not consume anymore!");
        }
        else
        {
            calorieIntake+= item.Calories;
            if(item.IsSweet)
            {
                calorieIntake+=10;
            }
            ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());

        }
        
    }
    public override bool IsFull 
    { get
        {
            if (calorieIntake >=1500) return true;
            else return false;
        }
    }

    public SweetTooth(string name) : base(name) { }
}