﻿using Application.Services.Repositories;
using Core.Persistence.Repositories.EntityFrameworkCore;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
    public ModelRepository(BaseDbContext context) : base(context)
    {
    }
}
