using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_PREFINAL_EXAM.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = "";
        public string[] Choices { get; set; } = Array.Empty<string>();
        public string YourAnswer { get; set; } = "";
    }
}