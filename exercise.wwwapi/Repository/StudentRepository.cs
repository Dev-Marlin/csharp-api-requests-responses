using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        //StudentCollection students;

        public StudentRepository()
        {
            //students = new StudentCollection();
        }
        public Student Add(Student entity)
        {
            StudentCollection.Add(entity);
            return entity;
        }

        public Student Delete(string firstName)
        {
            Student entity = StudentCollection.getAll().Find(x => (x.FirstName.ToLower()).Equals(firstName.ToLower()));

            //StudentCollection.getAll().Remove(entity);
            StudentCollection.Remove(entity);

            return entity;
        }

        public IEnumerable<Student> GetAll()
        {
            return StudentCollection.getAll();
        }

        public Student GetByName(string firstName)
        {
            Student entity = StudentCollection.getAll().Find(x => (x.FirstName.ToLower()).Equals(firstName.ToLower()));

            return entity;
        }

        public Student Update(string firstName, string update)
        {
            Student entity = StudentCollection.getAll().Find(x => (x.FirstName.ToLower()).Equals(firstName.ToLower()));


            entity.FirstName = update;

            return entity;
        }
    }
}
