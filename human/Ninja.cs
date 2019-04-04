using System.Collections.Generic;
abstract class Ninja
{
    protected int calorieIntake;
    public string Name;
    public List<IConsumable> ConsumptionHistory;
    public Ninja(string name)
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
        Name = name;
    }
    public abstract bool IsFull { get; }
    public abstract void Consume(IConsumable item);
}