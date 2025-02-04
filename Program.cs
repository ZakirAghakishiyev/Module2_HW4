namespace Module2_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jPhone=new JPhone("Zakirin Teleofnu");
            Console.WriteLine(jPhone.Call("4123456"));
            jPhone.AddAccount("Zakir");
            jPhone.AddAccount("User1");
            jPhone.AddAccount("User2");
            jPhone.AddAccount("User3");
            jPhone.PrintAllAccounts();
            jPhone.PrintInfo();
        }
    }
}
