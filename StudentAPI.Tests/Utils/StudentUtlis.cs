using StudentAPI.Controllers;
using StudentAPI.Models;
using StudentAPI.Services;
using StudentAPI.Tests.Stubs;

namespace StudentAPI.Tests.Utils
{
    public static class StudentUtils
    {
        public static List<Estudiante> GetTestStudents()
        {
            return new List<Estudiante>
            {
                new Estudiante { CI = 45622343, Nombre = "Ambar Choque", Nota = 95, },
                new Estudiante { CI = 7838712, Nombre = "Alexander Choque Polo", Nota = 90, },
                new Estudiante { CI = 7563434, Nombre = "Jeronimo Perez", Nota = 40, },
            };
        }

        public static StudentController GetTestStudentControllerStub()
        {
            StudentController controller = new StudentController(new StudentServiceStub());
            return controller;
        }
    }
}
