using System.Diagnostics;

namespace FinalTask13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("Text1.txt");
            char[] delimitersChars = new char[] { ' ', '\r', '\n' };
            string[] words = text.Split(delimitersChars, StringSplitOptions.RemoveEmptyEntries);
            
            //List
            List<string> list = new List<string>();

            var duration1 = Stopwatch.StartNew();

            for (int i = 0; i < words.Length; i++)
                list.Add(words[i]);

            Console.WriteLine("List: "+duration1.Elapsed.TotalMilliseconds);

            //LinkedList
            LinkedList<string> linkedList = new LinkedList<string>();

            var duration2 = Stopwatch.StartNew();

            for (int i = 0; i < words.Length; i++)
                linkedList.AddFirst(words[i]);
           
            Console.WriteLine("LinkedList: "+ duration2.Elapsed.TotalMilliseconds);
       }
    }
}