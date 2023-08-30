using System.Linq;

namespace Core.Persistance.Repositories;

public interface IQuery<T>
{
    IQueryable<T> Query();
}
