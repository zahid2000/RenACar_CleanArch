using Application.Services.Repositories;
using Core.Persistence.Repositories.EntityFrameworkCore;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
{
    public TransmissionRepository(BaseDbContext context) : base(context)
    {
    }
}