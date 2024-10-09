using System.Text;

namespace ConsoleAppPersian.Extensions
{
    public static class ConsoleExtensions
    {
        public static void PersianWrite(this string text)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorLeft = Console.BufferWidth - text.Length;
            Console.WriteLine(text.Persian());
        }
        public static void PersianWriteLine(this string text)
        {
            text.PersianWrite();
            Console.WriteLine();
        }

        public static string PersianReadLine()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            String result = String.Empty;
            int charachterIndex = 1;

            do
            {
                if (charachterIndex == Console.BufferWidth)
                {
                    charachterIndex = 1;
                    Console.WriteLine();
                }

                Console.CursorLeft = Console.BufferWidth - charachterIndex;

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.KeyChar == 13)
                    break;

                result = String.Concat(result, consoleKeyInfo.KeyChar);

                charachterIndex++;

            } while (true);

            return result;
        }
    }
}