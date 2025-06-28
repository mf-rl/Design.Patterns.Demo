namespace Design.Patterns.Demo._3.Behavioral
{
    public static class InterpreterExample
    {
        public static void Run()
        {
            // (5 + 3) - 2
            IExpression expression = new Subtract(
                new Add(
                    new Number(5),
                    new Number(3)
                ),
                new Number(2)
            );

            Console.WriteLine($"Interpreter Result: {expression.Interpret()}");
        }
    }
    public class Number : IExpression
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public int Interpret()
        {
            return _value;
        }
    }
    public class Subtract : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public Subtract(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() - _right.Interpret();
        }
    }
    public class Add : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public Add(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
    public interface IExpression
    {
        int Interpret();
    }
}
