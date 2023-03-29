using System.Collections;

namespace Task13_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May" };
            var missing = new ArrayList() { 1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            AddMissing(months, missing);

            foreach (var month in months) Console.WriteLine(month);
        }

        static void AddMissing(List<string> months, ArrayList missing)
        {
            foreach (var mnth in missing.GetRange(4, 7))
            {
                months.Add(mnth.ToString());
            }
        }

        private static void GetMissing(List<string> months, ArrayList missing)
        {
            // инициализируем массив для 7 нужных нам недостающих элементов
            var missedArray = new string[7];

            // извлекаем эти элементы из ArrayList, и копируем в массив
            missing.GetRange(4, 7).CopyTo(missedArray);

            // Добавляем наш массив в конец списка
            months.AddRange(missedArray);

            // смотрим, что получилось
            foreach (var month in months)
                Console.WriteLine(month);

        }
    }
}