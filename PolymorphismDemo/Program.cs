// See https://aka.ms/new-console-template for more information

using PolymorphismDemo.Device;

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

