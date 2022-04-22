using System.Net.Http;
using System.Xml;

//using Microsoft.AspNetCore.WebUtilities;

namespace domain.Models;

public abstract class FCARHelper
{
    public const int INVALID_YEAR_ERROR = -9999;
    public abstract string GetCourseId(string CourseId);

    public abstract string ValidateCourseCode(string CourseCode);

    public abstract string GetCourseCode(string courseCode);    

    //public abstract string GetCourseName(string CourseName);

    //public abstract string GetCourseSemester(string Semester);

    public abstract string ValidateSemester(string Semester);

    //public abstract int GetYear(int Year);

    public abstract int ValidateYear(int Year);

    //public abstract string GetCourseInstructor(string CourseInstructor);
}

public class ABETFCARHelper : FCARHelper
{


    public override string GetCourseId(string CourseId)
    {
        return String.Empty;
    }

    public override string GetCourseCode(string courseCode)
    {
        // we need to implement actual business rules once we have
        // the repository pattern in place
        return courseCode;
    }

    public override string ValidateCourseCode(string CourseCode)
    {

        // establish business rules
        if (CourseCode.StartsWith("CIDM"))
        {
            return CourseCode;
        }
        else if(CourseCode.Length == 8){
            return CourseCode;
        }
        else 
        {
            return string.Empty;
        }
    }
    public override string ValidateSemester(string Semester)
    {

        // establish business rules
        if (Semester.StartsWith("Fall"))
        {
            return Semester;
        }
        else if(Semester.StartsWith("Spring")){

            return Semester;
        }
        else 
        {
            return string.Empty;
        }
    }
    public override int ValidateYear(int Year)
    {

        // establish business rules
        if(Year < DateTime.Today.Year)
        {
            return Year;
        }
        else
        {
            return INVALID_YEAR_ERROR;
        }
    }
}