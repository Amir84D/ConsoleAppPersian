
using ConsoleAppPersian.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "تست زبان پارسی!";

        "متن خور را وارد کنید؟".PersianWriteLine();

        string text = ConsoleExtensions.PersianReadLine();

        Console.WriteLine();

        ("متن شما هست: " + text).PersianWriteLine();

        Console.ReadLine();
    }
}
