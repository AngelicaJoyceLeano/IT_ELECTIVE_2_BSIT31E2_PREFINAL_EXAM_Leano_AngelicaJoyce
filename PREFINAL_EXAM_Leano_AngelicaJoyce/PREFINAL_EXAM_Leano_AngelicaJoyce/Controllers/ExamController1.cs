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
            };

            return View(questions);
        }
    }
}