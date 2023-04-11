Console.Write("Enter number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberA}, {numberB} -> {Math.Pow(numberA, numberB)}");