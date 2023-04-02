using System.Net;

namespace FinalTask13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] delimitersChars = new char[] { ' ', '\r', '\n' };

            string text = File.ReadAllText("Text1.txt");
            string noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] wordsArr = noPunctuationText.ToLower().Split(delimitersChars, StringSplitOptions.RemoveEmptyEntries);  //Меняем регистр что бы не было задвоений одних и тех же слов с заглавной и строчной буквы

            List<string> wordsList = new List<string>(wordsArr);
            wordsList.Sort();

            HashSet<string> uniqueWords = new HashSet<string>(wordsArr);
            Dictionary<string, int> wordsByCount = new Dictionary<string, int>();

            foreach (string uniqueWord in uniqueWords)
            {
                foreach (string word in wordsArr)
                {
                    if (uniqueWord == word)
                    {
                        if (wordsByCount.TryGetValue(uniqueWord, out int count))
                            wordsByCount[uniqueWord] = ++count;
                        else
                            wordsByCount.Add(uniqueWord, 1);
                    }
                }
            }
            
            //Имею опыт работы с LINQ, поэтому ничего другого не выдумал)
            var commonWords = wordsByCount.OrderByDescending(x => x.Value)   //Сортируем по убыванию
                                .Where(x=>x.Key.Length>3)           //Отсеиваем местоимения и предлоги
                                .Take(10);                          //Оставляем первые 10

            Console.WriteLine("Слово - Кол-во повторений");
            foreach (var item in commonWords)
                Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}