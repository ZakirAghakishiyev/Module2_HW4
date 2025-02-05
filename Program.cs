namespace Module2_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jPhone = new JPhone("Zakirin Teleofnu","KD123412");
            Console.WriteLine(jPhone.Call("412354596"));
            Console.WriteLine(jPhone.Call("3103712"));
            Console.WriteLine(jPhone.Call("6981723"));
            jPhone.AddAccount("Zakir");
            jPhone.AddAccount("User1");
            jPhone.AddAccount("User2");
            jPhone.AddAccount("User3");
            jPhone.CurrentUser("Zakir");
            jPhone.PrintNumberOfValidCalls();
            jPhone.DeleteAccount("User1");
            jPhone.PrintAllAccounts();
            jPhone.PrintInfo();

            Console.WriteLine(new string('-',40));
            var jPhonePro = new JPhonePlus("Zakirin Teleofnu","KS12312");
            Console.WriteLine(jPhonePro.Call("412354596"));
            Console.WriteLine(jPhonePro.Call("3103712"));
            Console.WriteLine(jPhonePro.Call("6981723"));
            jPhonePro.AddAccount("Zakir");
            jPhonePro.AddAccount("User1");
            jPhonePro.AddAccount("User2");
            jPhonePro.AddAccount("User3");
            jPhonePro.AddAccount("User4");
            jPhonePro.AddAccount("User5");
            jPhonePro.AddAccount("User6");
            jPhonePro.CurrentUser("Zakir");
            jPhonePro.PrintNumberOfValidCalls();
            jPhonePro.DeleteAccount("User1");
            jPhonePro.PrintAllAccounts();
            jPhonePro.PrintInfo();
        }
    }
}
