using System;
public class Nokia : Phone, IRingable
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) { }
   
    public string Ring()
    {
        // your code here
        return $"...{_ringTone}...";
    }
    public string Unlock()
    {
        // your code here
        return $" Nokia { _versionNumber} unlocke with passcode";
    }
    public override void DisplayInfo()
    {
        // your code here    
        for(int i =0;i<50;i++){
            Console.Write("$");
        }
        Console.Write("\n") ;
        Console.WriteLine("Nokia "+_versionNumber);
        Console.WriteLine("Battery Percentage: "+_batteryPercentage);
        Console.WriteLine("Carrier: "+_carrier);
        Console.WriteLine("Ring Tone: "+_ringTone);
        for (int i = 0; i < 50; i++)
        {
            Console.Write("$");
        }
        Console.Write("\n");


    }
}
