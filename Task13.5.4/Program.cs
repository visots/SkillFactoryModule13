using System.Security.Cryptography.X509Certificates;

namespace Task13._5._4
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "pop":
                        words.TryPop(out string poped);
                        Console.WriteLine("Удалили: " + poped);
                        break;
                    case "peek":
                        words.TryPeek(out string peeked);
                        Console.WriteLine("Первый в стеке: "+peeked);
                        break;
                    default:
                        words.Push(input);
                        break;

                }


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}