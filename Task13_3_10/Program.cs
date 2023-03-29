namespace Task13_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            var textChars = text.Trim().ToCharArray();

            var swearingSings = new char[] { ',', ' ', '.' };
            var nums = new char[] { '0', '1', '2','3','4','5','6','7','8','9','0'};

            HashSet<char> chars = new HashSet<char>(textChars);
            
            chars.ExceptWith(swearingSings);

            if(chars.Overlaps(nums)) 
                Console.WriteLine("В тексте есть числа");

            Console.WriteLine("Уникальных букв в тексте " + chars.Count);
        }
    }
}