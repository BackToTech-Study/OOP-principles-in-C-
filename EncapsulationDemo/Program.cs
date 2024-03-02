// See https://aka.ms/new-console-template for more information

using EncapsulationDemo.ComputeEngine;

double AddNumbers(double value1, double value2)
{
    return value1 + value2;
}
Operation<double> NumberDivision = new(AddNumbers);
var result = NumberDivision.Execute(10, 5)
                    ? $"Result: {NumberDivision.Result}"
                    : $"Error: {NumberDivision.ErrorMessage}";
Console.WriteLine(result);


var result2 = ((double)3).Add(7).Subtract(2);
Console.WriteLine($"Result: {result2}");


var engine = new NumericComputeEngine();
engine.Add(10);
engine.Subtract(5);
Console.WriteLine($"Result: {engine.CurrentValue}");