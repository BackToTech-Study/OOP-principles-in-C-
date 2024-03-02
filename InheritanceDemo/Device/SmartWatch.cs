namespace InheritanceDemo.Device;

public class SmartWatch : CoreDevice
{
    public override string GetDeviceType()
    {
        return "SmartWatch";
    }
    
    // public and protected members from the base class are also available in the derived class
}