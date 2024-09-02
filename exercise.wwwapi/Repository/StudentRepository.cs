using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class StudentRepository : IRepository
    {
        private List<Student> _students;
        public Student AddStudent(Student student)
        {
            StudentCollection.Add(student);
            return student;
        }

        public Student DeleteStudent(string firstname)
        {
             return StudentCollection.DeleteStudent(firstname);
            
        }

        public List<Student> getAll()
        {
           return StudentCollection.getAll();
        }

        public Student GetOneStudent(string firstname)
        {
            return StudentCollection.GetOneStudent(firstname);
        }

        public Student UpdateStudent(string firstname, Student newStudentDetails)
        {
            return StudentCollection.UpdateStudent(firstname, newStudentDetails);
        }
    }
}
