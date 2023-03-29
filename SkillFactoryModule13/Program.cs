using System.IO;
using System.Text;

namespace SkillFactoryModule13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\visot\\source\\repos\\SkillFactoryModule13\\SkillFactoryModule13\\cdev_Text.txt");

            char[] delimitersChars = new char[] { ' ', '\r', '\n' };

            var words = text.Split(delimitersChars, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);


        }
    }
}