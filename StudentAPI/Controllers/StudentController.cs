using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Estudiante> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpGet("{ci}")]
        public Estudiante GetByCi(int ci)
        {
            return _studentService.GetByCi(ci);
        }

        [HttpPost]
        public Estudiante Create(Estudiante student)
        {
            return _studentService.Create(student);
        }

        [HttpPut("{ci}")]
        public Estudiante Update(int ci, Estudiante updatedStudent)
        {
            return _studentService.Update(ci, updatedStudent);
        }

        [HttpDelete("{ci}")]
        public Estudiante Delete(int ci)
        {
            return _studentService.Delete(ci);
        }

        [HttpGet("is-approved{ci}")]
        public bool HasApproved(int ci)
        {
            return _studentService.HasApproved(ci);
        }
    }
}
