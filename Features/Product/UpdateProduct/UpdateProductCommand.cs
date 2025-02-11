using MediatR;
using WebVslApiTraining.Shared;

namespace WebVslApiTraining.Features.Product.UpdateProduct
{
    public record UpdateProductCommand(UpdateProductRequest Product)
        : IRequest<ServiceResponse>
    {

    }
}
