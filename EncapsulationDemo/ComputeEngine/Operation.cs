namespace EncapsulationDemo.ComputeEngine
{
    internal class Operation<T>
    {
        private readonly Func<T, T, T> _operation; // private fields, properties, and methods are only accessible within the class

        internal Operation(Func<T, T, T> operation) 
        {
            this._operation = operation;
        }

        private T? _result;
        internal T? Result => _result; 

        private string _errorMessage = string.Empty;
        internal string ErrorMessage => _errorMessage;

        internal bool Execute(T value1, T value2) // internal fields, properties, and methods are accessible from anywhere within the same assembly
        {
            try {
                _result = _operation(value1, value2);
            }
            catch (Exception ex) {
                _errorMessage = ex.Message;
                return false;
            }

            return true;
        }
    }
}