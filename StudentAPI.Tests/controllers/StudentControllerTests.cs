using Moq;
using StudentAPI.Controllers;
using StudentAPI.Models;
using StudentAPI.Services;
using StudentAPI.Tests.Utils;

namespace StudentAPI.Tests.Controllers
{
    public class StudentControllerTests
    {
        [Fact]
        public void Student_With_Highest_Grade_A51_Should_Pass()
        {
            // Arrange
            StudentController controller = StudentUtils.GetTestStudentControllerStub();            
            int studentCI = 7838712; // Nota 90 de Alexander

            // Act
            var result = controller.HasApproved(studentCI);

            // Assert
            Assert.IsType<bool>(result); // Debe ser un booleano
            Assert.True(result); // Debe aprobar
        }

        [Fact]
        public void Student_With_Grade_Lower_Than_51_Should_Not_Pass()
        {
            // Arrange
            StudentController controller = StudentUtils.GetTestStudentControllerStub();
            int studentCI = 7563434; // Nota 40 de Jeronimo

            // Act
            var result = controller.HasApproved(studentCI);

            // Assert
            Assert.IsType<bool>(result); // Debe ser un booleano
            Assert.False(result); // No debe aprobar
        }

        [Fact]
        public void Student_TheNameMustBeTheEntered()
        {
            // Arrange
            var mock = new Mock<IStudentService>();
            int ciNewStudent = 87345678;
            var estudiante = new Student { CI = ciNewStudent, Nombre = "Laura Sifuentes", Nota = 60 };

            mock.Setup(s => s.GetByCi(ciNewStudent)).Returns(estudiante);

            var controller = new StudentController(mock.Object);

            // Act
            var resultado = controller.GetByCi(ciNewStudent);

            // Assert
            Assert.NotNull(resultado); // Asegura que el resultado no sea null
            Assert.IsType<Student>(resultado); // Asegura que el tipo sea Student
            Assert.Equal("Laura Sifuentes", resultado.Nombre); // El nombre debe coincidir
        }

        [Fact]
        public void Student_TheCIMustBeTheEntered()
        {
            // Arrange
            var mock = new Mock<IStudentService>();
            int ciNewStudent = 87345678;
            var estudiante = new Student { CI = ciNewStudent, Nombre = "Laura Sifuentes", Nota = 60 };            

            mock.Setup(s => s.GetByCi(ciNewStudent)).Returns(estudiante);

            var controller = new StudentController(mock.Object);

            // Act
            var resultado = controller.GetByCi(ciNewStudent);

            // Assert
            Assert.NotNull(resultado); // Asegura que el resultado no sea null
            Assert.IsType<Student>(resultado); // Asegura que el tipo sea Student
            Assert.Equal(ciNewStudent, resultado.CI); // El CI debe coincidir
        }


    }
}
