using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Application.Features.Brands.Rules;

public class BrandBusinessRules:BaseBusinessRules
{
    private readonly IBrandRepository  _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandNameCannotBeDuplicatedWhenInserted(string name,CancellationToken cancellationToken=default)
    {
        bool brand = await _brandRepository.AnyAsync(b=>b.Name==name,cancellationToken:cancellationToken);

        if (brand)
            throw new BusinessException(BrandsMessages.BrandNameExists);
    }
}
