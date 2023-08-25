using FluentAndBoolean;

class Program
{
    static void Main(string[] args)
    {
        checkBothBoolCondition();
        FluentChecker();
        Console.ReadLine();
    }

    public static void checkBothBoolCondition()
    {
        DoubleBooolean _boolean = new DoubleBooolean();

        if(_boolean == true && _boolean == false)
        {
            Console.WriteLine("True\n");
        }
        else
        {
            Console.WriteLine("False\n");
        }
    }

    public static void FluentChecker()
    {
        var firstCondition = new FluentCalculator().One.Plus.Result;
        var shouldBe3 = new FluentCalculator().One.Plus.Two.Result;
        var shouldBeMinus1 = new FluentCalculator().One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four.Result;
        var allOperations = new FluentCalculator().One.Plus.Two.Multiply.Two.DividedBy.Two.Result;
        var allNumbers = new FluentCalculator().One.Plus.Two.Plus.Three.Plus.Four.Plus.Five.Plus.Six.Plus.Seven.Plus.Eight.Plus.Nine.Plus.Ten - 10;

        Console.WriteLine($"Should be 1: {firstCondition}" +
            $"\nShould be 3: {shouldBe3}" +
            $"\nShould be minus 1: {shouldBeMinus1}" +
            $"\nUsing all operations: {allOperations}" +
            $"\nAll numbers using integers: {allNumbers}");
    }
}