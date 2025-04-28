using SAP.ContentContext;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("CLEAN CODE", "clean-code"));
            articles.Add(new Article("Fundamentos orientação a objetos", "orientacao-objetos"));
            articles.Add(new Article("Fundamentos CSHARP", "c-sharp"));
            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSHARP = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-asp-net");
            courses.Add(courseOOP);
            courses.Add(courseCSHARP);
            courses.Add(courseAspNet);

            var careers = new List<Career>();

            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(2, "Especialista OOP", "Seja um especialista .NET", courseOOP);
            var careerItem2 = new CareerItem(1, "Comece por aqui", "Seja um especialista .NET", courseCSHARP);
            var careerItem3 = new CareerItem(3, "Especialista ASPNET", "Seja um especialista .NET", null);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}