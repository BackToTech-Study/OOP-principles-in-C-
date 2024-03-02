using InheritanceDemo.Device;

namespace InheritanceDemo.DeviceCollection;

public class UniqueDeviceCollection<T> : DeviceCollection<T> where T : CoreDevice
{
    // polymorphism archived by overriding base class behaviour
    public override bool AddDevice(CoreDevice device)
    {
        if (Devices.Contains(device))
        {
            return false;
        }
        
        Devices.Add(device);
        return true;
    }
}