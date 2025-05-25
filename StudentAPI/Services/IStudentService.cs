using StudentAPI.Models;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetByCi(int ci);
        Student Create(Student student);
        Student Update(int ci, Student updatedStudent);
        Student Delete(int ci);
        Boolean HasApproved(int ci);
    }
}