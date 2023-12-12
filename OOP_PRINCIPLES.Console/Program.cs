using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    private string DebuggerDisplay => ToString();
}