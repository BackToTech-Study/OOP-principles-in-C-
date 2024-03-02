namespace AbstractionDemo.Device;

file struct DeviceInfo //only available in this file
{
    public string Id { get; set; }
    public string Type { get; set; }
}

public class SmartWatch : CoreDevice, IMessageGenerator, IDataObject
{
    public override string GetDeviceType()
    {
        return "SmartWatch";
    }
    
    public string GetIdentificationMessage()
    {
        return $"Device {GetId()} of type {GetDeviceType()}";
    }

    public object GetDataObject()
    {
        return new DeviceInfo
        {
            Id = GetId(),
            Type = GetDeviceType()
        };
    }
}