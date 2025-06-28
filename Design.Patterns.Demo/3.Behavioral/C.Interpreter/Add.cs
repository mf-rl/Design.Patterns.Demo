namespace Design.Patterns.Demo._3.Behavioral.C.Interpreter
{
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
}
