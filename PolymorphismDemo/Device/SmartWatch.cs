namespace PolymorphismDemo.Device;

public class SmartWatch : CoreDevice, IMessageGenerator
{
    public override string GetDeviceType()
    {
        return "SmartWatch";
    }
    
    public string GetIdentificationMessage()
    {
        return $"Device {GetId()} of type {GetDeviceType()}";
    }
}