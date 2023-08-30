using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand:IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            CreatedBrandResponse response = new();
            response.Name = request.Name;
            response.Id=Guid.NewGuid();
            return await Task.FromResult(response);
        }
    }
}
