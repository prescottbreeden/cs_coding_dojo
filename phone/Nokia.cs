namespace phone
{
  public class Nokia : Phone, IRingable
  {
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring()
    {
      return "Ring ring ring ring ring... banana phone...";
    }
    public string Unlock()
    {
      return "Phone unlocked";
    }
    public override void DisplayInfo()
    {
      System.Console.WriteLine($"Version Number: { VersionNumber }"); 
      System.Console.WriteLine($"Battery: { BatteryPercentage }");
      System.Console.WriteLine($"Carrier: { Carrier }");
      System.Console.WriteLine($"Ring Tone: { RingTone }");
    }
  }
}
