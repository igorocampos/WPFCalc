namespace WPFCalc
{
    public interface IOperation
    {
        decimal DoOperation(decimal val1, decimal val2);
    }

    public class Sum : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2) => val1 + val2;
    }

    public class Subtraction : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2) => val1 - val2;
    }

    public class Division : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2) => val1 / val2;
    }
    public class Multiplication : IOperation
    {
        public decimal DoOperation(decimal val1, decimal val2) => val1 * val2;
    }
}
