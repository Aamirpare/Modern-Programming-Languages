using OnlineStore.Models;

namespace OnlineStore.Extensions
{
    public static class StudentExtensions
    {
        public static void AddDefaultCourses(this Student student)
        {
            student.Courses = new System.Collections.Generic.List<Course>();
            student.Courses.Add(new Course { CourseId = 1, Title = "Modern Programming", Credits = 4 });
            student.Courses.Add(new Course { CourseId = 2, Title = "Advance Web", Credits = 3 });
            student.Courses.Add(new Course { CourseId = 3, Title = "Comprehensive English", Credits = 2 });
        }
    }
}