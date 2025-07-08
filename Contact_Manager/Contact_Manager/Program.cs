



using System.Net.Mail;

SortedList<string, Info> contactInfo = new SortedList<string, Info>();
List<Info> list = new List<Info>();

string userInput;
do
{
    Console.WriteLine("Enter Your choice!!!");
    Console.WriteLine("S - To View the contacts");
    Console.WriteLine("A - To Add contact");
    Console.WriteLine("D - To Delete a contact");
    Console.WriteLine("E - To Exit");
    userInput = Console.ReadLine().ToUpper();
    HandleChoice(userInput);
}
while (userInput != "E");

void HandleChoice(string choice)
{
    switch (choice)
    {
        case "S":
            ViewContacts();
            break;
        case "A":
            AddContact();
            break;
    }
}

void ViewContacts()
{
    string choice;

    Console.WriteLine("A - To view all contacts");
    Console.WriteLine("N - To view contacts by name");
    Console.WriteLine("PH - To view contacts by number");
    Console.WriteLine("E - To go back to Main Menu");
    choice = Console.ReadLine().ToUpper();
    switch (choice)
    {
        case "A":
            DisplayAllContacts();
            break;
        case "N":
            SearchByNumber();
            break;
        case "PH":
            SearchByPhone();
            break;
        case "E":
            return;
    }
}

void SearchByPhone()
{
    throw new NotImplementedException();
}

void SearchByNumber()
{
    throw new NotImplementedException();
}

void DisplayAllContacts()
{
    throw new NotImplementedException();
}

void AddContact()
{
    string name;
    string number;
    uint phone;
    string mail;
    String notes;

    Console.WriteLine("Enter the name");
    name = Console.ReadLine();
  
    do
    {
        Console.WriteLine("Enter the number");
        number = Console.ReadLine();
    }
    while (!uint.TryParse(number, out uint result));
    phone = uint.Parse(number);
    Console.WriteLine("Enter the mail");
    mail = Console.ReadLine();
    Console.WriteLine("Write any notes about the contact");
    notes = Console.ReadLine();

    Info obj = new Info(name, mail, phone, notes);


}


class Info
{
    public string name;
    public string email;
    public uint phone;
    public string notes;

    public Info(string name, string email, uint phone, string notes)
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.notes = notes;
    }
}