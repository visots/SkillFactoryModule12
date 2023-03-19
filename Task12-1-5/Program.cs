namespace Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = FillUserList();

            foreach (User user in users)
            {
                Console.WriteLine($"Привет {user.Name}!");

                if (!user.IsPremium)
                {
                    Console.WriteLine($"НЕ КУПИЛ ПРЕМИУМ, {user.Name}? СМОТРИ РЕКЛАМУ!!!");
                    ShowAds();
                }
            }
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }

        static void ShowAds()
        {
            Console.WriteLine("\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу.\n");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static List<User> FillUserList()
        {
            var users = new List<User>();
            users.Add(new User() { Name = "Вася", Login = "Vaysa", IsPremium = true });
            users.Add(new User() { Name = "Петя", Login = "Petya", IsPremium = false });
            users.Add(new User() { Name = "Гриша", Login = "Grisha", IsPremium = true });
            return users;
        }
    }
}