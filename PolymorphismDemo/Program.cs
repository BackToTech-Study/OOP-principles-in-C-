// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.Json;
using PolymorphismDemo.Device;
using PolymorphismDemo.Formatter;

// polymorphism achieved through the use of interfaces - all objects are treated as IMessageGenerator
List<IMessageGenerator> deviceCollection = new()
{
    new SmartWatch(),
    new SmartWatch(),
    new SmartTag("car")
};

var doorTag = new SmartTag("door");
deviceCollection.Add(doorTag);
deviceCollection.Add(doorTag.Clone());

foreach (var device in deviceCollection)
{
    Console.WriteLine(device.GetWelcomeMessage());
}

foreach (var device in deviceCollection)
{
    PrintSoldDevice(device);
}

void PrintSoldDevice(IMessageGenerator device)
{
    Console.WriteLine($"Sold {device.GetIdentificationMessage()}");
}

// only the important data is exposed the rest of the functionality is abstracted with the use of the IDataObject interface
List<object> jsonDeviceCollection = deviceCollection.Select(device => ((IDataObject)device).GetDataObject()).ToList();
var httpContent = new StringContent(JsonSerializer.Serialize(jsonDeviceCollection), Encoding.UTF8, "application/json");
Console.WriteLine(httpContent.ReadAsStringAsync().Result);