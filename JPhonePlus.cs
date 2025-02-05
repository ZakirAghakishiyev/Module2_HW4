namespace Module2_HW4
{
    internal class JPhonePlus:JPhone
    {
        public string Phone = "JPhonePlus";
        private string _serviceTag;
        public JPhonePlus(string deviceName,string serviceTag) :base(deviceName)
        {
            DeviceName = deviceName;    
            _serviceTag = serviceTag;
        }

        static int userCount = 0;
        static int callCount = 0;
        public string[] Users = new string[5];
        public int MemorySize = 64;

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

                for (int i = 0; i < Users.Length; i++)
                {
                    if (Users[i] == null) Users[i] = username;
                    break;
                }
                Console.WriteLine($"Account {username} was added");
                userCount++;
            }
            else Console.WriteLine("You cannot add more accounts, limit is reached");
        }

        public void PrintServiceTag()
        {
            Console.WriteLine($"Service tag is {_serviceTag}");
        }

        
    }
}
