namespace Task13_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Contact> contacts = new Dictionary<string, Contact>()
            {
                ["Петя"] = new Contact(12345,"petya@mail.ru"),
                ["Вася"] = new Contact(56789,"vasya@mail.ru"),
                ["Дима"] = new Contact(54321,"dima@mail.ru")
            };

            contacts.Add("Даша", new Contact(12321312, "dasha@mail.ru"));

            foreach(var contact in contacts)
            {
                Console.WriteLine(  $"{contact.Key} {contact.Value.PhoneNumber}"); 
            }

            if (contacts.ContainsKey("Даша"))
                contacts["Даша"] = new Contact(152421, "dasha@mail.ru");


            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} {contact.Value.PhoneNumber}");
            }


            Console.WriteLine();
            
        }
    }
    public class Contact // модель класса
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}