namespace CompositionDemo.ComputeEngine;

public class ComputeEngine<T>
{
    private T? _currentValue = default(T);
    public T? CurrentValue => _currentValue;
        
    public bool ApplyOperations(List<Operation<T>> operationCollection)
    {
        foreach (var operation in operationCollection)
        {
            var isSuccessful = operation.Execute(_currentValue);
            if (!isSuccessful)
            {
                return false;
            }
            _currentValue = operation.Result;
        }
        
        return true;
    }
}