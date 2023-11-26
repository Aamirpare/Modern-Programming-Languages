using EFCodeFirst.Data;
using System;
using System.Linq;

namespace EFCodeFirst.Repository
{
    public class StudentRepositoryTest
    {
        //Create a student repository instance
        StudentRepository StudentRepository = new StudentRepository(new SalesContext());
        
        //Create new student test method
        public void CreateStudentTest()
        {
            //Create new student entity instance
            var newStudentEntity = new Student { FullName = "Kajol Khanna", Email = "kajol.khanna@gmail.com" };

            //Add Entity to the Repository
            StudentRepository.Create(newStudentEntity);

            //Finally Save changes to the database
            StudentRepository.SaveChanges();
        }

        //Get all students test method 
        public void GetAllStudentsTest()
        {
            foreach (var s in StudentRepository.GetAll())
            {
                Console.WriteLine($"{s.StudentId}, {s.FullName}, {s.Email}");
            }
        }

        //Update student test method
        public void UpdateStudentTest()
        {
            int toBeUpdatedStudentId = 9;
            string fullName = "Sanam Khan";
            string email = "sanam.khan@gmail.com";
            
            //Find the student to be updated
            var toBeUpdatedStudent = StudentRepository.Find(s => s.StudentId == toBeUpdatedStudentId).FirstOrDefault();
            
            //update the required fields
            toBeUpdatedStudent.FullName = fullName;
            toBeUpdatedStudent.Email = email;

            //Add student to be updated to the Repository
            StudentRepository.Update(toBeUpdatedStudent);
            
            //Finally save changes
            StudentRepository.SaveChanges();
        }

        //Delete Student Test Method
        public void DeleteStudentTest()
        {
            //Id of the student to be deleted
            int toBeUpdatedStudentId = 8;

            //Find the student to be deleted by his student id
            var toBeDeletedStudent = StudentRepository.Find(s => s.StudentId == toBeUpdatedStudentId).FirstOrDefault();

            //delete student to be deleted from the Repository
            StudentRepository.Delete(toBeDeletedStudent);

            //Finally, save changes to the database
            StudentRepository.SaveChanges();
        }

    }
    public class RepositoryDemo
    {
        StudentRepositoryTest StudentRepositoryTest => new StudentRepositoryTest();
        public void ExecuteDemo()
        {
            //StudentRepositoryTest.CreateStudentTest();
            //StudentRepositoryTest.DeleteStudentTest();
            //StudentRepositoryTest.UpdateStudentTest();
            StudentRepositoryTest.GetAllStudentsTest();
            Console.ReadKey();
        }

    }
}
