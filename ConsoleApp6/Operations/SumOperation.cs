namespace ConsoleApp6.Operations
{
    internal class SumOperation : IMathOperation
    {
        public string GetOperationSign()
        {
            return "+";
        }

        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
}
