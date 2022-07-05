using GraphQLApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Models
{
    public class Query
    {
        IStudentService _studentService = null;
        public Query(IStudentService service)
        {
            _studentService = service;
        }
        public List<Student> Students => _studentService.GetStudents();
    }
}
