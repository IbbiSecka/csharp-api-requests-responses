using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public class StudentCollection
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() { FirstName="Nathan",LastName="King" },
            new Student() { FirstName="Dave", LastName="Ames" }
        };

        public static Student Add(Student student)
        {            
            _students.Add(student);

            return student;
        }

        public static List<Student> getAll()
        {
            return _students.ToList();
        }
        public static Student GetOneStudent(string firstname) {
            
            return _students.Where(x => x.FirstName == firstname).FirstOrDefault();
        }
        public static Student UpdateStudent(string firstname, Student newStudentDetails)
        {
            Student existingStudent = _students.Where(x  => x.FirstName == firstname).FirstOrDefault();
            existingStudent.FirstName = newStudentDetails.FirstName;
            existingStudent.LastName = newStudentDetails.LastName;
            return existingStudent;
        }
        public static Student DeleteStudent(string firstname) {
            Student theStudent = _students.Where(x =>  x.FirstName == firstname).FirstOrDefault();
            _students.Remove(theStudent);
            return theStudent;
        }
    };


}
