using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IRepository
    {
        Student AddStudent(Student student);
        List<Student> getAll();
        Student GetOneStudent(string firstname);
        Student UpdateStudent(string firstname, Student newStudentDetails);
        Student DeleteStudent(string firstname);

    }
}
