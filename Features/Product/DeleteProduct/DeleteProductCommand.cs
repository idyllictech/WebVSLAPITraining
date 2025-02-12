using MediatR;
using WebVslApiTraining.Shared;

namespace WebVslApiTraining.Features.Product.DeleteProduct
{
    public record DeleteProductCommand(int Id) : 
        IRequest<ServiceResponse>
    { 
    }
}
