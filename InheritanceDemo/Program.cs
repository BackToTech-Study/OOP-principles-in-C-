// See https://aka.ms/new-console-template for more information

using InheritanceDemo.Device;
using InheritanceDemo.DeviceCollection;

var watchCollection = new UniqueDeviceCollection<SmartWatch>();
watchCollection.AddDevice(new SmartWatch());
watchCollection.AddDevice(new SmartWatch());

foreach (var watch in watchCollection)
{
    Console.WriteLine(watch.GetWelcomeMessage());
}


var tagCollection = new DeviceCollection<SmartTag>();
var doorTag = new SmartTag("door");
var carTag = new SmartTag("car");
var doorTagClone = doorTag.Clone();
Console.WriteLine($"Door tag and clone are the same: {doorTag == doorTagClone}");

tagCollection.AddDevice(doorTag);
tagCollection.AddDevice(carTag);
tagCollection.AddDevice(doorTagClone);

foreach (var tag in tagCollection)
{
    Console.WriteLine(tag.GetWelcomeMessage());
}

