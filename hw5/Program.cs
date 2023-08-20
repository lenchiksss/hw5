using System.Text;

namespace hw5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Test();
            GC.Collect(); 
            Console.Read();

            void Test()
            {
                Play play = new Play("Наталка Полтавка", "Іван Котляревський", "П'єса", 1819);
            }

            var play1 = new Play("Украдене щастя", "Іван Франко", "П'єса", 1894);

            try
            {
                Console.WriteLine("Назва: {0}, Автор: {1}, Жанр: {2}, Рік: {3}", play1.Name, play1.Author, play1.Genre, play1.Year);
            }
            finally
            {
                play1.Dispose();
            }

            Console.WriteLine();

            using (var play2 = new Play("Лісова пісня", "Леся Українка", "П'єса", 1911))
            {
                Console.WriteLine("Назва: {0}, Автор: {1}, Жанр: {2}, Рік: {3}", play2.Name, play2.Author, play2.Genre, play2.Year);
            }

            Console.WriteLine();

            Test1();
            GC.Collect();
            Console.Read();

            void Test1()
            {
                Shop shop = new Shop("Сільпо", "м. Харків, вул. Пушкінська, 2", ShopTypes.Food);
            }

            var shop1 = new Shop("Nike", "м. Харків, вул. Пушкінська, 2", ShopTypes.Clothing);

            try
            {
                Console.WriteLine("Назва: {0}, Адреса: {1}, Тип: {2}", shop1.Name, shop1.Address, shop1.ShopType);
            }
            finally
            {
                shop1.Dispose();
            }
        }
    }
}