using Developerbackpack.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Developerbackpack.Webapi.Controllers
{
    public class StudentsController : ApiController
    {
        private IEnumerable<Student> _students;
        public StudentsController()
        {
            _students = StudentRepository.GetStudents();
        }
        // GET: Students
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        public Student Get(int id)
        {
            var student = _students.Where(n => n.Id == id).FirstOrDefault();
            if(student == null || student.Id == 0)
            {
                throw new StudentNotFoundException();
            }

            return student;
        }
    }
}