namespace WPFCalc
{
    public abstract class Operation
    {
        public abstract decimal DoOperation(decimal val1, decimal val2);
    }

    public class Sum : Operation
    {
        public override decimal DoOperation(decimal val1, decimal val2) => val1 + val2;
    }

    public class Subtraction : Operation
    {
        public override decimal DoOperation(decimal val1, decimal val2) => val1 - val2;
    }

    public class Division : Operation
    {
        public override decimal DoOperation(decimal val1, decimal val2) => val1 / val2;
    }
    public class Multiplication : Operation
    {
        public override decimal DoOperation(decimal val1, decimal val2) => val1 * val2;
    }
}
