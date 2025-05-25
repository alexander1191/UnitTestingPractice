using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Tests.Stubs
{
    public class StudentServiceStub : IStudentService
    {
        private List<Estudiante> _students;

        public StudentServiceStub()
        {
            _students = new List<Estudiante>()
            {
                new Estudiante { CI = 45622343, Nombre = "Ambar Choque", Nota = 95, },
                new Estudiante { CI = 7838712, Nombre = "Alexander Choque Polo", Nota = 90, },
                new Estudiante { CI = 7563434, Nombre = "Jeronimo Perez", Nota = 40, },
            };
        }

        public List<Estudiante> GetAll()
        {
            return _students;
        }

        public Estudiante GetByCi(int ci)
        {
            return _students.FirstOrDefault(s => s.CI == ci);
        }

        public bool HasApproved(int ci)
        {
            var student = _students.FirstOrDefault(p => p.CI == ci);
            if (student == null)
                return false;

            return student.Nota >= 51;
        }

        public Estudiante Create(Estudiante student)
        {
            _students.Add(student);
            return student;
        }

        public Estudiante Update(int ci, Estudiante updatedStudent)
        {
            var existing = _students.FirstOrDefault(s => s.CI == ci);
            if (existing != null)
            {
                existing.Nombre = updatedStudent.Nombre;
                existing.Nota = updatedStudent.Nota;
            }
            return existing;
        }

        public Estudiante Delete(int ci)
        {
            var student = _students.FirstOrDefault(s => s.CI == ci);
            if (student != null)
            {
                _students.Remove(student);
            }
            return student;
        }
    }
}
