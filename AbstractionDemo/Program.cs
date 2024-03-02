// See https://aka.ms/new-console-template for more information
// only the important data is exposed the rest of the functionality is abstracted with the use of the IDataObject interface

using System.Text;
using System.Text.Json;
using AbstractionDemo.Device;

List<IMessageGenerator> deviceCollection = new()
{
    new SmartWatch(),
    new SmartWatch(),
    new SmartTag("car"),
    new SmartTag("door")
};

List<object> jsonDeviceCollection = deviceCollection.Select(device => ((IDataObject)device).GetDataObject()).ToList();
var httpContent = new StringContent(JsonSerializer.Serialize(jsonDeviceCollection), Encoding.UTF8, "application/json");
Console.WriteLine(httpContent.ReadAsStringAsync().Result);
