namespace PhoneBook_App
{
    internal class Program
    {
        static List<string> names = new List<string>();
        static List<string> phonenumbers = new List<string>();

        static void Main()
        {
            Console.WriteLine("Welcome to PhoneBook App");

            while (true)
            {
                Console.WriteLine("1. Add  2. Search  3. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;

                    case "2":
                        SearchContact();
                        break;

                    case "3":
                        Console.WriteLine("Thanks for using Phonebook");
                        return;

                    default:
                        Console.WriteLine("Please enter the valid choice");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Phone: ");
            var phone = Console.ReadLine();

            names.Add(name);
            phonenumbers.Add(phone);

            Console.WriteLine("Contact Saved Successfully!");
        }

        static void SearchContact()
        {
            Console.Write("Search name: ");
            var searchName = Console.ReadLine();

            int index = names.IndexOf(searchName);

            if (index != -1)
                Console.WriteLine($"Phone: {phonenumbers[index]}");
            else
                Console.WriteLine("Contact not found");
        }
    }
}
        