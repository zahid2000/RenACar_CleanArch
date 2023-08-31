using Application.Services.Repositories;
using Core.Persistence.Repositories.EntityFrameworkCore;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}
