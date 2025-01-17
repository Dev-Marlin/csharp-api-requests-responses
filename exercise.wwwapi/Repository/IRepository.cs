namespace exercise.wwwapi.Repository
{
    public interface IRepository<T>
    {
        public T GetByName(string name);
        public IEnumerable<T> GetAll();
        public T Add(T entity);
        public T Update(string name, string update);
        public T Delete(string name);
    }
}
