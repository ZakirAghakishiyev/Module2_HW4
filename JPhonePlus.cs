using System.Xml;

namespace Module2_HW4
{
    internal class JPhonePlus:JPhone
    {
        public override string Phone { set; get; } = "JPhonePlus";
        public override int MemorySize { set; get; } = 64;
        public string[] Users = new string[5];
        public string[] Users2 = new string[5];

        public JPhonePlus(string deviceName,string serviceTag) :base(deviceName,serviceTag)
        {

        }

        //static int userCount = 0;
        //static int callCount = 0;


        public override string Call(string phoneNumber)
        {
            string invalid = "Invalid phone number, please check the number!";
            string calling = $"Calling to the number {phoneNumber}";

            if (phoneNumber.Length >= 6 && phoneNumber.Length <= 9)
            {
                if (phoneNumber[0] == '4' || phoneNumber[0] == '6')
                {
                    callCount++;
                    return calling;
                }


                else return invalid;
            }
            else return invalid;
        }

        public override void AddAccount(string username)
        {
            if (userCount < 5)
            {

                Users[userCount] = username;
                Console.WriteLine($"Account {username} was added");
                userCount++;
            }
            else Console.WriteLine("You cannot add more accounts, limit is reached");
        }

        public override void PrintAllAccounts()
        {
            if (userCount == 0) Console.WriteLine("No user accounts to display");
            else
            {
                foreach (string account in Users)
                {
                    if (account == null) continue;
                    Console.WriteLine(account);
                }
            }
        }

        public void PrintServiceTag()
        {
            Console.WriteLine($"Service tag is {ServiceTag}");
        }

        public override void DeleteAccount(string username)
        {
            int index = -1;
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i] == username)
                {
                    index = i; break;
                }
            }
            if (index == -1) Console.WriteLine(("No such user to delete"));
            else
            {
                int indexTmp = 0;
                foreach (var item in Users)
                {
                    if (item == null || item == Users[index]) continue;
                    Users2[indexTmp++] = item;
                }
                Users = new string[Users2.Length];
                for (int i = 0; i < Users.Length; i++)
                {
                    Users[i] = Users2[i];
                }
                userCount--;
                Users2= new string[userCount-1];
                Console.WriteLine($"{username} has been deleted");
            }
        }
    }
}

