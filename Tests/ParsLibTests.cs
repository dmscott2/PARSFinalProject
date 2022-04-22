using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

using domain.Models;

namespace Tests;

// https://xunit.net/docs/shared-context#class-fixture
// public  class NOAAHelperFixture : IDisposable
// {
//     public NOAAADDSStationHelper StationHelper { get; set; } = new NOAAADDSStationHelper();

//     public void Dispose(){}
// }

public class FCARHelperFixture : IDisposable
{
    public FCARHelper Helper { get; set; } = new ABETFCARHelper();

    public List<Course> CourseCodes { get; set; } = new List<Course>()
    {
        new Course()
        {
            CourseId = 1,
            CourseName = "CIDM4390",
            Section = 70,
            Semester = "Fall",
            Year = 2021,
            Course_Status = "Done",

        },
        new Course()
        {
            CourseId = 1,
            CourseName = "CIDM3350",
            Section = 01,
            Semester = "Fall",
            Year = 2021,
            Course_Status = "Done",

        },
    };

    public Dictionary<string, List<Course>> CourseAssignments { get; set; } = 
        new Dictionary<string, List<Course>>()
        {
            {
                "Jeffry Babb",
                new List<Course>() 
                {
                    new Course() 
                    {   
                        CourseId = 1, 
                        CourseName = "CIDM3350",
                        Section = 01,
                        Semester = "Fall",
                        Year = 2021,
                        Course_Status = "Done",

                    }
                }
            },
        };


    public void Dispose() { }

}

public class FCARTest : IClassFixture<FCARHelperFixture>
{

    /* Capturing Output in Xunit
     * https://xunit.net/docs/capturing-output
     */
    private readonly FCARHelperFixture fixture;
    private readonly ITestOutputHelper output;

    public FCARTest(ITestOutputHelper output, FCARHelperFixture fixture)
    {
        //this uses dependency injection in Xunit
        this.output = output;
        this.fixture = fixture;
    }

    [Fact(DisplayName = "Test that course code is valid")]
    public void TestCourseCodeIsValid()
    {

        // to validate/verify business rules

        // dotnet test --filter FullyQualifiedName~CanCreateNOAAURL --logger "console;verbosity=detailed"

        // Arrange
        // Act
        string courseCode = fixture.Helper.ValidateCourseCode("CIDM4390");
        output.WriteLine($"course code value is: {courseCode}");

        // Assert
        Assert.True(courseCode.Length > 0);
    }

    [Fact(DisplayName = "Test that course code is known")]
    public void TestCourseCodeExists()
    {

        // to validate/verify business rules

        // dotnet test --filter FullyQualifiedName~CanCreateNOAAURL --logger "console;verbosity=detailed"

        // Arrange
        // Act
        string courseCode = fixture.Helper.GetCourseCode("CIDM4390");
        output.WriteLine($"course code value is: {courseCode}");

        bool found = false;

        foreach (Course c in fixture.CourseCodes)
        {
            if (courseCode == c.CourseName)
            {
                found = true;
            }
        }

        // Assert
        Assert.True(found);        
    }
}