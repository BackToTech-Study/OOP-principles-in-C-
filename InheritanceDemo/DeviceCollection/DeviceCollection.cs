using System.Collections;
using InheritanceDemo.Device;

namespace InheritanceDemo.DeviceCollection;

public class DeviceCollection<T> : IEnumerable<T> where T : CoreDevice
{
    protected readonly List<CoreDevice> Devices = [];
    
    public virtual bool AddDevice(CoreDevice device)
    {
        Devices.Add(device);
        return true;
    }
    
    public virtual bool RemoveDevice(CoreDevice device)
    {
        return Devices.Remove(device);
    }
    
    public CoreDevice? GetDeviceById(string id)
    {
        return Devices.FirstOrDefault(d => d.GetId() == id);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var device in Devices)
        {
            yield return (T)device;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}