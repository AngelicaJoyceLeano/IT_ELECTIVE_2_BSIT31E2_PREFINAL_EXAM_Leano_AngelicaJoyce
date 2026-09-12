using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_PREFINAL_EXAM.Models;

namespace IT_ELECTIVE_2_PREFINAL_EXAM.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
{
    Number = 1,
    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
    Choices = new[]
    {
        "A. It makes C# code shorter",
        "B. It prevents the application from restarting",
        "C. It allows data to persist after the application stops",
        "D. It removes the need for MVC"
    },
    YourAnswer = "C"
},
                new Question
{
    Number = 2,
    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
    Choices = new[]
    {
        "A. Code-First",
        "B. Database-First",
        "C. Model-First",
        "D. Controller-First"
    },

    YourAnswer = "B"
},
                new Question
                {
                    Number = 3,
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Choices = new[]
                    {
                        "A. To create HTML pages automatically",
                        "B. To replace the MVC Controller",
                        "C. To map objects in code to relational database data",
                        "D. To replace the C# compiler"
                    },
                    YourAnswer = "C"
                },
                new Question
                {
                    Number = 4,
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    Choices = new[]
                    {
                        "A. DbContext",
                        "B. DbSetView",
                        "C. ControllerContext",
                        "D. RazorContext"
                    },
                    YourAnswer = "A"
                },
                new Question
                {
                    Number = 5,
                    Text = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Choices = new[]
                    {
                        "A. Deletes the database",
                        "B. Creates a new MVC project",
                        "C. Generates EF Core models and a DbContext from an existing database",
                        "D. Starts the MVC application"
                    },
                    YourAnswer = "C"
                },
                new Question
                {
                    Number = 6,
                    Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Choices = new[]
                    {
                        "A. Program.cs only",
                        "B. appsettings.json",
                        "C. Index.cshtml",
                        "D. Student.cs"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 7,
                    Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Choices = new[]
                    {
                        "A. One-to-One",
                        "B. One-to-Many",
                        "C. Many-to-Many",
                        "D. Many-to-One only"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 8,
                    Text = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Choices = new[]
                    {
                        "A. Primary key of Student",
                        "B. Foreign key referencing Section",
                        "C. Navigation property",
                        "D. Database connection string"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 9,
                    Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Choices = new[]
                    {
                        "A. It stores the database password",
                        "B. It represents a relationship to another entity",
                        "C. It creates a new database",
                        "D. It validates the student's name"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 10,
                    Text = "What does .Include() generally allow EF Core to do?",
                    Choices = new[]
                    {
                        "A. Delete the Section table",
                        "B. Load related Section data together with Students",
                        "C. Create a new Student",
                        "D. Validate Student input"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 11,
                    Text = "Why might a ViewModel be used when displaying Student and Section information?",
                    Choices = new[]
                    {
                        "A. To replace the database",
                        "B. To combine or shape the data specifically needed by the view",
                        "C. To automatically create database tables",
                        "D. To prevent controllers from using LINQ"
                    },
                    YourAnswer = "B"
                },
                new Question
                {
                    Number = 12,
                    Text = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                    Choices = new[]
                    {
                        "A. It loads the related Section navigation property",
                        "B. It creates a Section object manually",
                        "C. It removes the foreign key",
                        "D. It prevents the query from accessing the database"
                    },
                    YourAnswer = "A"
                },
            };

            return View(questions);
        }
    }
}