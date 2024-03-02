namespace EncapsulationDemo.ComputeEngine
{
    public class NumericComputeEngine
    {
        private double _currentValue;
        public double CurrentValue => _currentValue;
        
        private bool ApplyOperation(Operation<double> operation, double newValue)
        {
            var isSuccessful = operation.Execute(_currentValue, newValue);
            if (isSuccessful) {
                _currentValue = operation.Result;
            }
            return isSuccessful;
        }
        
        public bool Add(double newValue)
        {
            Operation<double> addOperation = new ((a, b) => a + b);
            return ApplyOperation(addOperation, newValue);
        } 
        
        public bool Subtract(double newValue)
        {
            Operation<double> subtractOperation = new ((a, b) => a - b);
            return ApplyOperation(subtractOperation, newValue);
        }
    }
}
