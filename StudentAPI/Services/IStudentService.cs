using StudentAPI.Models;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        List<Estudiante> GetAll();
        Estudiante GetByCi(int ci);
        Estudiante Create(Estudiante student);
        Estudiante Update(int ci, Estudiante updatedStudent);
        Estudiante Delete(int ci);
        Boolean HasApproved(int ci);
    }
}