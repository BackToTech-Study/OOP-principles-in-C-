namespace EncapsulationDemo.ComputeEngine
{
    internal static class SubtractNumbers
    {
        internal static double Subtract(this double previousResult, double newValue)
        {
            Operation<double> subtractOperation = new ((a, b) => a - b);
            if (subtractOperation.Execute(previousResult, newValue)) {
                return subtractOperation.Result;
            }

            throw new InvalidOperationException(subtractOperation.ErrorMessage);
        }
    }
}