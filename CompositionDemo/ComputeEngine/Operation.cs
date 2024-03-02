namespace CompositionDemo.ComputeEngine
{
    public class Operation<T>
    {
        private readonly Func<T?, T> _operation; 

        internal Operation(Func<T?, T> operation) 
        {
            _operation = operation;
        }

        private T? _result;
        internal T? Result => _result; 

        private string _errorMessage = string.Empty;
        internal string ErrorMessage => _errorMessage;

        internal bool Execute(T? value) 
        {
            try {
                _result = _operation(value);
            }
            catch (Exception ex) {
                _errorMessage = ex.Message;
                return false;
            }

            return true;
        }
    }
}