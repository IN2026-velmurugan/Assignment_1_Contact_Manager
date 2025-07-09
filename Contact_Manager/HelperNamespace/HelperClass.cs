using InfoNameSpace;
using System.ComponentModel.DataAnnotations;

namespace HelperNamespace
{
    public class help
    {
        public void DisplayInfo(Info obj)
        {
            Console.WriteLine($"Name : {obj.name} \tNumber : {obj.phone}\temail : {obj.email}\n");
        }
        public int FindByPhone(string phone, List<Info> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].phone == phone) return i;
            }
            return -1;
        }

        public int FindByName(string name, List<Info> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == name) return i;
            }
            return -1;
        }

        public void DeleteUser(int index, List<Info> list)
        {
            if (index != -1)
            {
                Console.WriteLine("User Deleted");
                DisplayInfo(list[index]);
                list.RemoveAt(index);
                return;
            }
            Console.WriteLine("User Not Found");
        }

        public void SearchUserDisplay(int index, List<Info> list)
        {
            if (index != -1)
            {
                Console.WriteLine("User found");
                DisplayInfo(list[index]);
                return;
            }
            Console.WriteLine("User Not Found");
        }

        public string GetNumber()
        {
            string number;
            do
            {
                Console.WriteLine("Enter the number");
                number = Console.ReadLine();
            }
            while (!long.TryParse(number, out long result)
            );
            //|| number.Length < 10);
            return number;
        }

        public string GetMailId()
        {
            string mailId;
            var emailValid = new EmailAddressAttribute();
            do
            {
                Console.WriteLine("Enter the Mail Address");
                mailId = Console.ReadLine();
            }
            while (!emailValid.IsValid(mailId));
            return mailId;
        }

        public void UpdateContactInfo(int index, List<Info> list)
        {
            if(index == -1)
            {
                Console.WriteLine("User Not Found");
                return;
            }
            string choice;
            do
            {
                Console.WriteLine("N - To Change Name of the User");
                Console.WriteLine("P - To Change Phone Number of the User");
                Console.WriteLine("NT - To Change Notes of the User");
                Console.WriteLine("M - To Change MailID of the User");
                Console.WriteLine("E - To Exit");
                choice = Console.ReadLine();
            }
            while (!IsValidChoice(choice));
            switch(choice)
            {
                case "N":
                    Console.WriteLine("Enter the New Name");
                    list[index].name = Console.ReadLine();
                    break;
                case "P":
                    Console.WriteLine("Enter the New Number");
                    list[index].phone = GetNumber();
                    break;
                case "NT":
                    Console.WriteLine("Enter the New Notes");
                    list[index].notes = Console.ReadLine();
                    break;
                case "M":
                    Console.WriteLine("Enter the New MailID");
                    list[index].email = Console.ReadLine();
                    break;
                default:
                    return;
            }
        }

        private bool IsValidChoice(string choice)
        {
            if (choice == "E" || choice == "N" || choice == "P" || choice == "NT" || choice == "M") return true;
            return false;
        }

        public bool IsValidSearchChoice(string choice)
        {
            if (choice == "E" || choice == "N" || choice == "P" || choice == "A" ) return true;
            Console.WriteLine();
            Console.WriteLine("NOT A VALID CHOICE");
            Console.WriteLine();
            return false;
        }
    }
}
