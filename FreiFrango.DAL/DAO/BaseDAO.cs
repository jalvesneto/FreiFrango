using FreiFrango.DAL;
using Microsoft.EntityFrameworkCore;

namespace FreiFrango.DAL.DAO
{
    public class BaseDAO<T> : IDAO<T> where T : class
    {
        public FreiFrangoContext _context { get; set; }

        public BaseDAO()
        {
            _context = new FreiFrangoContext();
        }
        public virtual T GetOne(long id)
        {
            using (_context = new FreiFrangoContext())
            {
                var obj = _context.Set<T>().Find(id);
                if (obj == null)
                {
                    throw new OperationCanceledException("Não foi possível encontrar uma tarefa com este Id");
                }
                return obj;
            }
        }

        public virtual T Create(T obj)
        {
            using (_context = new FreiFrangoContext())
            {
                _context.Add(obj);
                _context.SaveChanges();

                return obj;
            }

        }
        public virtual T Update(T obj)
        {
            using (_context = new FreiFrangoContext())
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

                return obj;
            }

        }
        public virtual void Delete(T obj, bool save = true)
        {
            using (_context = new FreiFrangoContext())
            {

                if (obj != null)
                {
                    _context.Remove(obj);

                    if (save)
                    {
                        _context.SaveChanges();
                    }
                }
            }
        }
        public virtual void Delete(long id, bool save = true)
        {
            using (_context = new FreiFrangoContext())
            {
                var obj = GetOne(id);

                if (obj != null)
                {
                    _context.Remove(obj);
                    if (save)
                    {
                        _context.SaveChanges();
                    }
                }
            }
        }
        public virtual IEnumerable<T> Get()
        {
            return _context.Set<T>();
        }
    }
}
