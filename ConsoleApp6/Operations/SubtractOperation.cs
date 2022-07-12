namespace ConsoleApp6.Operations
{
    internal class SubtractOperation : IMathOperation
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }

        public string GetOperationSign()
        {
            return "-";
        }
    }
}
