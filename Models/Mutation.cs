using GraphQLApi.Models;
using GraphQLApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrapgQlApp.Models
{
    public class Mutation
    {
        private readonly IStudentService _studentService;
        public Mutation(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Student> Create(Student student) 
                    => await _studentService.Create(student);
        public async Task<bool> Delete(Student student) =>
                    await _studentService.Delete(student);
    }
}
