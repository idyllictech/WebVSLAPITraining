using MediatR;

namespace WebVslApiTraining.Features.Product.GetProductById
{
    public record GetProductByIdQuery(int Id) : IRequest<GetProductResponse>
    {
    }
}
