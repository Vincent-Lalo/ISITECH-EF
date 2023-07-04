namespace EFCore.Shared;

public class Program_Help
{
    public static void SectionTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine($"--- {title} ---");
    }
    
    public static void Fail(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}