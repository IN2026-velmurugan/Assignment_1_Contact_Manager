

SortedList<string, Info> contactInfo = new SortedList<string, Info>();
Console.WriteLine("Hello User");
string userInput;
do
{
    Console.WriteLine("Enter Your choice!!!");
    Console.WriteLine("1 - To View the contacts");
    Console.WriteLine("2 - To Add contact");
    Console.WriteLine("3 - To Delete a contact");
    Console.WriteLine("4 - To Exit");
    userInput = Console.ReadLine();
    HandleChoice(int.Parse(userInput));
}
while (userInput != "4");

void HandleChoice(int choice)
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("Display");
            DisplayContactInfo();
            break;
        case 2:
            AddContact();
            break;
    }
}

void DisplayContactInfo()
{
    for(int i = 0; i < contactInfo.Count; i++)
    {
        Console.WriteLine($"{contactInfo.GetKeyAtIndex(i)} --- {contactInfo.GetValueAtIndex(i)}" +
            $" -- number of the person {contactInfo.GetValueAtIndex(i).phone}");
    }
}
void AddContact()
{
    Console.WriteLine("Enter the Phone number");
    string phone = Console.ReadLine();
    Console.WriteLine("Enter the Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Email");
    string mail = Console.ReadLine();
    Console.WriteLine("Enter notes about the person");
    string notes = Console.ReadLine();
    Info obj = new Info(name,mail,phone,notes);
    contactInfo.Add(name,obj);
}

public class Info
{
    public string name;
    public string email;
    public string phone;
    public string notes;

    public Info(string name, string email, string phone, string notes)
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.notes = notes;
    }
}