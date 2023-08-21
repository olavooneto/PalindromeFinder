
using palindromicFinder;

internal class Program
{
    static PalindromicService _palindromicService;

    public static void Main(string[] args)
    {
        _palindromicService = new PalindromicService();

        Console.WriteLine("Hello, please insert the word that you want to find the palindromic:");
        var text = Console.ReadLine();

        var result = _palindromicService.FindPalindromic(text);

        Console.WriteLine($"the longest palindrome found was: {result}");
    }
}