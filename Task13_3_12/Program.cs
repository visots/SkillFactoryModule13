using static System.Net.Mime.MediaTypeNames;

namespace Task13_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите текст:");
                string text = Console.ReadLine();

                ProcessText(text);
            }
        }

        static void ProcessText(string text)
        {
            var textChars = text.Trim().ToCharArray();

            var swearingSings = new char[] { ',', ' ', '.' };
            var nums = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            HashSet<char> chars = new HashSet<char>(textChars);

            chars.ExceptWith(swearingSings);

            if (chars.Overlaps(nums))
                Console.WriteLine("В тексте есть числа");

            Console.WriteLine("Уникальных букв в тексте " + chars.Count);
        }
    }
}