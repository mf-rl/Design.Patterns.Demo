namespace Design.Patterns.Demo._3.Behavioral.C.Interpreter
{
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
}
