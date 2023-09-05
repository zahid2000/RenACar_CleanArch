﻿using Application.Services.Repositories;
using Core.Persistence.Repositories.EntityFrameworkCore;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
{
    public FuelRepository(BaseDbContext context) : base(context)
    {
    }
}
