using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class StudentsIndexModel : PageModel
{
    public List<Student> Student { get; set; }

    public void OnGet()

    {
        // Populate with sample data
        Student = new List<Student>
        {
            new Student { StudentId = 1, FirstName = "Henry", LastName = "Matthews", Email = "Henry.Matthews@gmail.com", PhoneNumber = "647-456-0987" },
            new Student { StudentId = 2, FirstName = "Justin", LastName = "Alexander", Email = "Justin.Alexander@gmail.com", PhoneNumber = "647-875-3322" },
            new Student { StudentId = 3, FirstName = "Viktor", LastName = "Ves", Email = "Viktor.Ves@gmail.com", PhoneNumber = "647-333-6721" }
        };
    }
}
