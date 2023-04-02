using System.Diagnostics;

namespace Task13_4_5_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Contact> contacts = new Dictionary<string, Contact>()
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

        static void ShowContacts(Dictionary<string, Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} {contact.Value.PhoneNumber}");
            }
        }
    }

}