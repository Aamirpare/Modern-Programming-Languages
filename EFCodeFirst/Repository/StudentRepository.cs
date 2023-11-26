/*
    Author      :   Aamir Parre
    Description :   Note the StudentRepository that inherits the common operation from the BaseRepository
                    and implements the IStudentRepository interface for any specific student requirement
                    in the future. This way it is easy to mantain and develop in any future perspective
                    requirements. 
    Date		:	25th November, 2023
    Location	:	G - 11 / 4 Home, Islamabad 
*/

using EFCodeFirst.Data;
using System.Data.Entity;

namespace EFCodeFirst.Repository
{
    public interface IStudentRepository
    {
    }

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
