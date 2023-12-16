using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
        public List<Course> Courses { get; set; }
    }

}