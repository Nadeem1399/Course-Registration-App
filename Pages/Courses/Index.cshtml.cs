using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class CoursesIndexModel : PageModel
{
    public List<Course> Courses { get; set; }

    public void OnGet()
    {
        // Populate with sample data
        Courses = new List<Course>
        {
            new Course { CourseId = 1, CourseNumber = "ENG101", CourseName = "Introduction to English", Description = "Fundamentals of English and reading" },
            new Course { CourseId = 2, CourseNumber = "MATH101", CourseName = "Introduction to Math", Description = "Fundamentals of Math" },
            new Course { CourseId = 3, CourseNumber = "Science101", CourseName = "Introduction to Science", Description = "Fundamentals of Science" }
        };
    }
}
