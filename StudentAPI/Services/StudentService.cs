using StudentAPI.Models;

namespace StudentAPI.Services
{
    public class StudentService : IStudentService
    {
        private List<Estudiante> _students;

        public StudentService()
        {
            _students = new List<Estudiante>
            {
                new Estudiante { CI = 7838712, Nombre = "Alexander Choque Polo", Nota = 97 }
            };
            
        }

        public List<Estudiante> GetAll()
        {
            return _students;
        }

        public Estudiante GetByCi(int ci)
        {
            var student = _students.Find(s => s.CI == ci);
            if (student == null)
            {
                student = new Estudiante { CI = -1, Nombre = "Not Found", Nota = 0, };
            }
            return student;
        }

        public Estudiante Create(Estudiante student)
        {
            Estudiante createdStudent;
            if (student.Nota < 0 || student.Nota > 100)
            {
                createdStudent = new Estudiante { CI = -1, Nombre = student.Nombre + " | Nota Not Available", Nota = 0, };
            }
            else
            {
                student.CI = _students.Count > 0 ? _students.Max(s => s.CI) + 1 : 1;
                _students.Add(student);
                createdStudent = student;
            }
            return createdStudent;
        }

        public Estudiante Update(int ci, Estudiante updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.CI == ci);

            student.Nombre = updatedStudent.Nombre;
            student.Nota = updatedStudent.Nota;

            return student;
        }

        public Estudiante Delete(int ci)
        {
            var student = _students.FirstOrDefault(s => s.CI == ci);
            if (student != null)
            {
                _students.Remove(student);
                return student;
            }
            return null;
        }

        public Boolean HasApproved(int ci)
        {
            var student = _students.FirstOrDefault(p => p.CI == ci);
            if (student == null)
                return false;

            return student.Nota >= 51;
        }
    }
}
