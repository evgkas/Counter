public class Counter
{
    public static void Main()
    {
        Console.WriteLine("String:");
        string inputLine = Console.ReadLine();
        Int32 maxSymbols = 0;
        Int32 symbolCounter = 1;

        for (int i = 1; i < inputLine.Length; i++)
        {
            if (inputLine[i] != inputLine[i - 1])
            {
                symbolCounter++;
            }
            else
            {
                symbolCounter = 1;
            }

            if (symbolCounter > maxSymbols)
            {
                maxSymbols = count;
            }
        }

        Console.WriteLine($"length = " + inputLine.Length);
        Console.WriteLine($"There is {maxSymbols} different symbols in a row");
    }
}