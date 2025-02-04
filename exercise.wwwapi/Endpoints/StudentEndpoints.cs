﻿using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.EndPoint
{
    public static class StudentEndpoints
    {
        public static void Initialize(WebApplication app)
        {
            var student = app.MapGroup("student");

            student.MapPost("/create", CreateStudent);

            student.MapGet("/getall", GetAllStudents);

            student.MapGet("/getbyname/{name}", GetStudentByName);

            student.MapPut("/update/{name}", UpdateStudent);

            student.MapDelete("/delete/{name}", DeleteStudent);

        }

        // Methods for the endpoints
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateStudent(IRepository<Student> repository, Student student)
        {
            repository.Add(student);
            return TypedResults.Created("Created", student);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllStudents(IRepository<Student> repository)
        {
            //return list
            return TypedResults.Ok(repository.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetStudentByName(IRepository<Student> repository, string name)
        {
            //return student
            return TypedResults.Ok(repository.GetByName(name));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateStudent(IRepository<Student> repository, string name, string update)
        {
            //return student
            return TypedResults.Created("Created", repository.Update(name, update));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteStudent(IRepository<Student> repository, string name)
        {
            //return student
            return TypedResults.Ok(repository.Delete(name));
        }
    }
}
