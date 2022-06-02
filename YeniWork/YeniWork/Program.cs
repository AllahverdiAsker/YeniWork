using System;

namespace YeniWork
{
    class Program
    {
        static void Main(string[] args)
        {


            User user1 = new User();

            user1.SetUsername("Hasan Pashadost");
            user1.SetPassword("Whatisthis3");

            Console.WriteLine(user1.GetUserName());
            Console.WriteLine(user1.GetPassword());


        }
    }
}
