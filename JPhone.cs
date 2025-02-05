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
        public virtual string Phone { set; get; } = "JPhone";
        public string[] Users = new string[3];
        public string[] Users2 = new string[3];
        public string currentUser;
        protected string ServiceTag;
        public string DeviceName { get; set; }
        public virtual int MemorySize { set; get; } = 32;

        protected int userCount = 0;
        protected int callCount = 0;
        public JPhone(string deviceName, string serviceTag)
        {
            DeviceName = deviceName;
            ServiceTag = serviceTag;
        }

        public virtual string Call(string phoneNumber)
        {
            string invalid = "Invalid phone number, please check the number!";
            string calling = $"Calling to the number {phoneNumber}";

            if (phoneNumber.Length >= 6 && phoneNumber.Length <= 8)
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

                Users[userCount] = username;
                Console.WriteLine($"Account {username} was added");
                userCount++;
            }
            else Console.WriteLine("You cannot add more accounts, limit is reached");
        }

        public virtual void PrintAllAccounts()
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

        public void CurrentUser(string username)
        {
            foreach (var item in Users)
            {
                if (item == username) currentUser = username;
                return;
            }



        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Phone} is called {DeviceName}, it has {MemorySize}GB of memory and {userCount} user acounts.");
            if (currentUser != null) Console.WriteLine($"Current user is {currentUser}");
            else Console.WriteLine("There is not user currently logged in");
        }

        public void PrintNumberOfValidCalls()
        {
            Console.WriteLine($"You have made {callCount} valid calls");
        }

        public virtual void DeleteAccount(string username)
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
                Users2 = new string[userCount - 1];
                Console.WriteLine($"{username} has been deleted");

            }
        }
    }
}