/*
    Author      :   Aamir Parre
    Description :   Note the CourseRepository that inherits the common operation from the BaseRepository
                    and implements the ICourseRepository interface for any specific course requirement
                    in the future. This way it is easy to mantain and develop in any future perspective 
                    requirements. 
    Date		:	25th November, 2023
    Location	:	G - 11 / 4 Home, Islamabad 
*/
using EFCodeFirst.Data;
using System.Data.Entity;

namespace EFCodeFirst.Repository
{
    public interface ICourseRepository
    {

    }
    public class CourseRepositoty : BaseRepository<Course>, ICourseRepository  
    {
        public CourseRepositoty(DbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
