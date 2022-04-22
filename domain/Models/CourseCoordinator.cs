namespace domain.Models;

public class CourseCoordinator
{
    public int CoordinatorId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<Course>? Courses {get; set;} 
}