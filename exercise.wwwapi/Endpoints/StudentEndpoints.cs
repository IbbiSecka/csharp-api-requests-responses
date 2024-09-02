using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class StudentEndpoints
    {
        public static void ConfigureProductEndpoint(this WebApplication app)
        {
            var prods = app.MapGroup("students");
            prods.MapPost("/", Post);
            prods.MapGet("/", GetAll);
            prods.MapGet("/{name}", GetOne);
            prods.MapPut("/{id}", Update);
            prods.MapDelete("/{id}", DeleteOne);

        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static IResult Post(IRepository students, Student student)
        {
            if (students.getAll().Count == 0)

            {
                return TypedResults.NotFound("No students");
            }
            return TypedResults.Ok(students.AddStudent(student));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult GetAll(IRepository students)
        {
            return TypedResults.Ok(students.getAll());
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetOne(IRepository students, string name) {
             
            return TypedResults.Ok(students.GetOneStudent(name));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult Update(IRepository students, Student newStudentinfo, string name) {
            Student student = students.getAll().Where(x => x.FirstName == name).FirstOrDefault();
            student.FirstName = newStudentinfo.FirstName;
            student.LastName = newStudentinfo.LastName;
            return TypedResults.Ok(student);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult DeleteOne(IRepository students) {
            
        }
    }
}
