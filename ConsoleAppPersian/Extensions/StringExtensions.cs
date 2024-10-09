namespace ConsoleAppPersian.Extensions
{
    public static class StringExtensions
    {
        public static string Persian(this string text)
        {
            return String.Join("", text.Reverse());
        }
    }
}