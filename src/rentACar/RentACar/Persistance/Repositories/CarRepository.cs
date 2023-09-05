using Application.Services.Repositories;
using Core.Persistence.Repositories.EntityFrameworkCore;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context)
    {
    }
}
