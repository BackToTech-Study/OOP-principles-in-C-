namespace EncapsulationDemo.ComputeEngine
{
    internal static class AddNumbers
    {
        internal static double Add(this double previousResult, double newValue) // public fields, properties, and methods are accessible from anywhere
        {
            Operation<double> addOperation = new ((a, b) => a + b);
            if (addOperation.Execute(previousResult, newValue)) {
                return addOperation.Result;
            }

            throw new InvalidOperationException(addOperation.ErrorMessage);
        }
    }
}