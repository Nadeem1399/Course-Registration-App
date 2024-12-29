using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class InstructorsIndexModel : PageModel
{
    public List<Instructor> Instructor { get; set; }

    public void OnGet()
    {
        // Populate with sample data
        Instructor = new List<Instructor>
        {
            new Instructor { InstructorId = 1, FirstName = "Mark", LastName = "Jones", Email = "mark.jones@gmail.com", Course = new Course { CourseName = "English" } },
            new Instructor { InstructorId = 2, FirstName = "Sam", LastName = "Parker", Email = "sam.parker@gmail.com", Course = new Course { CourseName = "Math" } }
        };
    }
}
