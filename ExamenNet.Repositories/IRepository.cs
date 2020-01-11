using System.Collections.Generic;


namespace ExamenNet.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList();
    }
}
