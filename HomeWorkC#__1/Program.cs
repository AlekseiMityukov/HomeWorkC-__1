namespace HomeWorkC___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users user1 = new Users("Yejhgjg", "HJJHd123")
            {
                NickName = "Alexandr",
            };

            Users user2 = new Users("RBHBKK", "Rollp12");


            Users user3 = new Users("Prosstpo", "Windw3")
            {
                NickName = "SimpleLuck",
                Mail = "LuckyMan@gmail.com"
            };

            Users user4 = new Users("Fagset", "Rom213")
            {
                Mail = "Paradox@mail.ru"
            };


            Console.WriteLine($"Логин:{user1.Login} Пароль:{user1.Password}");
            

        }
    }
}
