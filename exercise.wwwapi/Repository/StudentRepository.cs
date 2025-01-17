using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        StudentCollection students;

        public StudentRepository()
        {
            students = new StudentCollection();
        }
        public Student Add(Student entity)
        {
            students.Add(entity);
            return entity;
        }

        public Student Delete(string firstName)
        {
            Student entity = students.getAll().Find(x => (x.FirstName).Equals(firstName));

            students.getAll().Remove(entity);

            return entity;
        }

        public IEnumerable<Student> GetAll()
        {
            return students.getAll();
        }

        public Student GetByName(string firstName)
        {
            Student entity = students.getAll().Find(x => (x.FirstName).Equals(firstName));

            return entity;
        }

        public Student Update(string firstName, string update)
        {
            Student entity = students.getAll().Find(x => (x.FirstName).Equals(firstName));

            string[] s = update.Split(" ");

            entity.FirstName = s[0];
            entity.LastName = s[1];

            return entity;
        }
    }
}
