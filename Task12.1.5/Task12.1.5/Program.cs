using System;
using System.Collections.Generic;
using System.Threading;

namespace Task12._1._5
{
    class Program
    {
		static void Main()
		{
			var UserList = new List<User>()
			{
				new User() { Name = "Имя", Login = "Imya", IsPremium = true },
				new User() { Name = "Второй", Login = "Second", IsPremium = false }
			};
			CheckPremium(UserList);
			Console.ReadKey();
		}

		static void CheckPremium(List<User> users)
		{ 
			foreach (var user in users)
            {
                Console.WriteLine($"Приветствуем, {user.Name}!");
				if (!user.IsPremium)
                {
					ShowAds();
                }
                Console.WriteLine();
            }
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}
	}
}
