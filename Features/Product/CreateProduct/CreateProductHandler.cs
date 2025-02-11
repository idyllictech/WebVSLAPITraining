using Mapster;
using MediatR;
using WebVslApiTraining.Infrastructure;
using WebVslApiTraining.Shared;

namespace WebVslApiTraining.Features.Product.CreateProduct
{
    public class CreateProductHandler(AppDbContext context)
        : IRequestHandler<CreateProductCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.Product.Adapt<Domain.Product>();
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return new ServiceResponse(true, "Saved");
        }
    }
}
