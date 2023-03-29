namespace Task13_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact("Петя",12345,"petya@mail.ru"),
                new Contact("Вася",56789,"vasya@mail.ru"),
                new Contact("Дима",54321,"dima@mail.ru")
            };

            AddUnique(new Contact("Даша", 123321, "dasha@mail.ru"),contacts);
            Console.WriteLine();
            AddUnique(new Contact("Дима", 54321, "dima@mail.ru"), contacts);
        }

        static void AddUnique(Contact contact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            foreach (var cnt in phoneBook)
            {
                if (cnt.Name == contact.Name)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(contact);

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var cnt in phoneBook)
                Console.WriteLine(cnt.Name + ": " + cnt.PhoneNumber);

        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}