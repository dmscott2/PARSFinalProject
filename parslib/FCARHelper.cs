using System.Net.Http;
using System.Xml;

// using Microsoft.AspNetCore.WebUtilities;

namespace parslib;

public abstract class FCARHelper
{
    public abstract string GetCourseId(string CourseId);

    public abstract string ValidateCourseCode(string CourseCode);

    public abstract string GetCourseCode(string courseCode);    

    //public abstract string GetCourseName(string CourseName);

    //public abstract string GetCourseSemester(string CourseSemester);

    //public abstract string GetAcademic_Year(string Academic_Year);

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
}