namespace Task13_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contact> contacts = new Dictionary<string, Contact>()
            {
                ["Петя"] = new Contact(12345, "petya@mail.ru"),
                ["Вася"] = new Contact(56789, "vasya@mail.ru"),
                ["Дима"] = new Contact(54321, "dima@mail.ru")
            };

            contacts.TryAdd("Даша", new Contact(12321312, "dasha@mail.ru"));
           
            ShowContacts(contacts);

            if (contacts.TryGetValue("Даша", out Contact cnt))
                cnt.PhoneNumber = 123121;

            ShowContacts(contacts);

            Console.WriteLine();

        }

        static void ShowContacts(Dictionary<string, Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} {contact.Value.PhoneNumber}");
            }

        }
    }
    public class Contact // модель класса
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
    }
}