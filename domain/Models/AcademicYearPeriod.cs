namespace domain.Models;

public enum Semester
{
    FALL,
    SPRING,
}

public class AcademicYearPeriod
{
    public int Year { get; set; }
    public Semester Semester { get; set; }
   
}
