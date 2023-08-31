using Core.Application.Dtos;

namespace Application.Features.Brands.Dtos;

public class GetListBrandListItemDto:IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
