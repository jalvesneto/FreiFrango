namespace FreiFrango.DAL.DAO
{
    public interface IDAO<T> where T : class
    {
        T Create(T obj);
        T Update(T obj);
        void Delete(T obj, bool save = true);
        void Delete(long id, bool save = true);
        T GetOne(long id);
        IEnumerable<T> Get();
    }
}
