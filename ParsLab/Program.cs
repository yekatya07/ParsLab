using DB;

namespace ParsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();
            db.Add(1, "", "");
            //IWebDriver driverr = new ChromeDriver(); // Создание объекта-браузера
            //driverr.Navigate().GoToUrl("https://pikabu.ru/best");
            //var articles = driverr.FindElements(By.ClassName("story"));

            //Console.WriteLine(articles.Count);

            //foreach (var article in articles)
            //{
            //    var message = article.FindElement(By.ClassName("story__title")).Text;
            //    var name = article.GetAttribute("data-author-name");
            //    var id = article.GetAttribute("data-story-id");

            //    Console.WriteLine($"{id} - {name} - {message}");

            //    //DB bd = new DB();
            //    //bd.Add(int.Parse(id), message, name);
            //}
        }
    }
}
