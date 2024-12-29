// Instructor.cs
public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
}
