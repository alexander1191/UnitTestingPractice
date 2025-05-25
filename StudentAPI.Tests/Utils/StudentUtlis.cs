using StudentAPI.Controllers;
using StudentAPI.Models;
using StudentAPI.Services;
using StudentAPI.Tests.Stubs;

namespace StudentAPI.Tests.Utils
{
    public static class StudentUtils
    {
        public static List<Student> GetTestStudents()
        {
            return new List<Student>
            {
                new Student { CI = 45622343, Nombre = "Ambar Choque", Nota = 95, },
                new Student { CI = 7838712, Nombre = "Alexander Choque Polo", Nota = 90, },
                new Student { CI = 7563434, Nombre = "Jeronimo Perez", Nota = 40, },
            };
        }

        public static StudentController GetTestStudentControllerStub()
        {
            StudentController controller = new StudentController(new StudentServiceStub());
            return controller;
        }
    }
}
