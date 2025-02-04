using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    internal class JPhone
    {
        public string[] Users =new string[3];
        public string DeviceName {  get; set; }
        public int MemorySize = 32;
        public decimal Price = 999;

        static int userCount = 0;
        static int callCount = 0;
        public JPhone(string deviceName)
        {
            DeviceName = deviceName;

        }

        public string Call(string phoneNumber)
        {
            string invalid="Invalid phone number, please check the number!";
            string calling = $"Calling to the number {phoneNumber}";
            //if (phoneNumber.Length < 6 || phoneNumber.Length > 8) return invalid;
            //else if (phoneNumber[0] != '4' || phoneNumber[0] != '6') return invalid;
            //else return calling;

            if(phoneNumber.Length >= 6 && phoneNumber.Length <= 8)
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

        public void AddAccount(string username)
        {
            if (userCount < 3)
            {
                Users[userCount]=username;
                Console.WriteLine($"Account {username} was added");
                userCount++;
            }
            else Console.WriteLine("You cannot add more accounts, limit is reached");
        }

        public void PrintAllAccounts()
        {
            if(userCount ==0) Console.WriteLine("No user accounts to display");
            else
            {
                foreach(string account in Users) Console.WriteLine(account); 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Jphone is called {DeviceName}, it has {MemorySize}GB of memory and {userCount-1} user acounts and costs {Price}$.");
        }
    }
}
