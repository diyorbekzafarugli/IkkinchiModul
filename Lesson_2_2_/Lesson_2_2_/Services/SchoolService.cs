using Lesson_2_2_.Models;

namespace Lesson_2_2_.Services;

public class SchoolService
{
    public List<School> Schools = new List<School>();


    public Guid? AddSchool(School school)
    {
        foreach (var schoolInList in Schools)
        {
            if (schoolInList.Name == school.Name && schoolInList.Number == school.Number)
            {
                return null;
            }
        }
        school.SchoolId = Guid.NewGuid();
        Schools.Add(school);
        return school.SchoolId;
    }

    public bool DeleteSchool(Guid guid)
    {
        for (int i = 0; i < Schools.Count; i++)
        {
            if (Schools[i].SchoolId == guid)
            {
                Schools.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public School? GetSchool(string location, int num)
    {
        foreach (var school in Schools)
        {
            if (school.Location == location && school.Number == num)
            {
                return school;
            }
        }
        return null;
    }


    public bool UpdateSchool(string location, int num, string nameOld, string nameNew)
    {
        for (int i = 0; i < Schools.Count; i++)
        {
            if (Schools[i].Location == location && Schools[i].Number == num && Schools[i].Name == nameOld)
            {
                Schools[i].Name = nameNew;
                return true;
            }
        }
        return false;
    }
}
