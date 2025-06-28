namespace Design.Patterns.Demo._3.Behavioral.C.Interpreter
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
}
