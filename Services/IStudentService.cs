using GraphQLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Task<Student> Create(Student student);
        Task<bool> Delete(Student student);
    }
}
