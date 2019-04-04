using System;
public class Galaxy : Phone, IRingable
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring()
    {
        // your code here
        return $"...{_ringTone}...";
    }
    public string Unlock()
    {
        // your code here
        return $" Galaxy { _versionNumber} unlocke with fingerprint scanner";
    }
    public override void DisplayInfo()
    {
        // your code here    
        for (int i = 0; i < 50; i++)
        {
            Console.Write("#");
        }
        Console.Write("\n");
        Console.WriteLine("Galaxy " + _versionNumber);
        Console.WriteLine("Battery Percentage: " + _batteryPercentage);
        Console.WriteLine("Carrier: " + _carrier);
        Console.WriteLine("Ring Tone: " + _ringTone);
        for (int i = 0; i < 50; i++)
        {
            Console.Write("#");
        }
        Console.Write("\n");
    }
}
