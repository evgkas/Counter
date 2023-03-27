Console.WriteLine("String:");
string line = Console.ReadLine();
Int32 max = 0;
Int32 count = 1;

for (int i = 1; i < line.Length; i++)
{
    if (line[i] != line[i - 1])
    {
        count++;
    }
    else count = 1;
    if (count > max)
    {
        max = count;
    }
}

Console.WriteLine($"length = " + line.Length);
Console.WriteLine($"There is {max} different symbols in a row");