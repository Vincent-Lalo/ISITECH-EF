namespace EFCore.Shared;

public class ProgramHelp
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