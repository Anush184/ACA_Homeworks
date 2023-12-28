using GenericOperationsUtility;

Console.WriteLine("Numeric Calculation:");
ICalculationUtility<int> intCalculator = new NumericCalculationUtility();
int intQuotient;
int intRemainder;

Console.WriteLine($"Addition: {intCalculator.Add(5, 3)}");
Console.WriteLine($"Subtraction: {intCalculator.Subtract(5, 3)}");
Console.WriteLine($"Multiplication: {intCalculator.Multiply(5, 3)}");
Console.WriteLine($"Division: {intCalculator.Divide(15, 3, out intQuotient)}, Quotient: {intQuotient}");
intCalculator.QuotientAndRemainder(15, 3, out intQuotient, out intRemainder);
Console.WriteLine($"Quotient: {intQuotient}, Remainder: {intRemainder}");

Console.WriteLine("\nString Calculation:");
ICalculationUtility<string> stringCalculator = new StringCalculationUtility();
string stringQuotient;
string stringRemainder;

Console.WriteLine($"Addition: {stringCalculator.Add("Good, ", "feelings!")}");


try
{
    Console.WriteLine($"Subtraction: {stringCalculator.Subtract("Good", "feelings")}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}

try
{
    Console.WriteLine($"Multiplication: {stringCalculator.Multiply("Good", "feelings")}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}

try
{
    Console.WriteLine($"Division: {stringCalculator.Divide("Good feeleings", "feelings", out stringQuotient)}, Quotient: {stringQuotient}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}

try
{
    stringCalculator.QuotientAndRemainder("Good feeleings", "feelings", out stringQuotient, out stringRemainder);
    Console.WriteLine($"Quotient: {stringQuotient}, Remainder: {stringRemainder}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
