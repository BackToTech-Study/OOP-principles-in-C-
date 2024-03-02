// See https://aka.ms/new-console-template for more information

using CompositionDemo.ComputeEngine;

// composition enables runtime behavior changes
var addFive = new Operation<double>(oldValue => oldValue + 5);
var multiplyByTwo = new Operation<double>(oldValue => oldValue * 2);
var divideByThree = new Operation<double>(oldValue => oldValue / 3);

List<Operation<double>> operationCollection = new()
{
    addFive,
    addFive, 
    addFive, 
    multiplyByTwo, 
    divideByThree
};

var computeEngine = new ComputeEngine<double>();

var isSuccessful = computeEngine.ApplyOperations(operationCollection);
Console.WriteLine($"Is successful: {isSuccessful}");
Console.WriteLine($"Result: {computeEngine.CurrentValue}");