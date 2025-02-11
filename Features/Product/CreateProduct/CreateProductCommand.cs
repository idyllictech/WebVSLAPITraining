using MediatR;
using WebVslApiTraining.Shared;

namespace WebVslApiTraining.Features.Product.CreateProduct
{
    public record CreateProductCommand(CreateProductRequest Product)
        : IRequest<ServiceResponse>
    {
    }
}
