using System.Diagnostics;
using Task13_4_5_Dict;

namespace Task13_4_5_DictSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Contact> contacts = new SortedDictionary<string, Contact>()
            {
                ["Петя"] = new Contact(12345, "petya@mail.ru"),
                ["Вася"] = new Contact(56789, "vasya@mail.ru"),
                ["Дима"] = new Contact(54321, "dima@mail.ru"),
                ["Коля"] = new Contact(54321, "dima@mail.ru"),
                ["Григорий"] = new Contact(54321, "dima@mail.ru")
            };

            ShowContacts(contacts);

            var stopWatch = Stopwatch.StartNew();

            contacts.TryAdd("Оля", new Contact(12321312, "dasha@mail.ru"));

            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

            ShowContacts(contacts);
        }

        static void ShowContacts(SortedDictionary<string, Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} {contact.Value.PhoneNumber}");
            }
        }
    }
}
