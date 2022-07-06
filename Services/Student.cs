using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Services
{
    public class StudentService : IStudentService
    {
        public async Task<Student> Create(Student student)
        {
            Students.Add(student);
            return student;
        }
        private List<Student> Students = new List<Student>();
        public List<Student> GetStudents()
        {
            for(int i = 1; i <= 9; i++)
            {
                Students.Add(new Student
                {
                     StudentId= i,
                     Name = "STU" + i,
                     Roll= "1000" + i
                });
            }
            return Students;
        }
    }
}
