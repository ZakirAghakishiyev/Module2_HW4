using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    internal class JPhone
    {
        public string Phone = "JPhone";
        public string[] Users =new string[3];
        public string[] Users2 = new string[3];
        public string currentUser;
        public string DeviceName {  get; set; }
        public int MemorySize = 32;
        public decimal Price = 999;

        static int userCount = 0;
        static int callCount = 0;
        public JPhone(string deviceName)
        {
            DeviceName = deviceName;

        }

        public virtual string Call(string phoneNumber)
        {
            string invalid="Invalid phone number, please check the number!";
            string calling = $"Calling to the number {phoneNumber}";
            
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

        public virtual void AddAccount(string username)
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

        public void CurrentUser(string username)
        {
            foreach(var item  in Users)
            {
                if (item==username) currentUser = username;
                return;
            }
            
            

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Phone} is called {DeviceName}, it has {MemorySize}GB of memory and {userCount} user acounts and costs {Price}$.");
            if(currentUser!=null) Console.WriteLine($"Current user is {currentUser}");
        }

        public void PrintNumberOfValidCalls()
        {
            Console.WriteLine($"You have made {callCount} valid calls");
        }

        public void DeleteAccount(string username)
        {
            bool notAvailable = true;
            for(int i = 0; i < Users.Length; i++)
            {
                if (Users[i] == username)
                {
                    notAvailable = false;
                    Console.WriteLine("Deleted");
                }
                else
                {
                    Users2[i] = username;
                }
            }
            Users = new string[Users2.Length];
            Users = Users2;
            if(notAvailable) Console.WriteLine("There is no such user");
        }
    }
}
