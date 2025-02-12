using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebVslApiTraining.Infrastructure;
// ReSharper disable All

namespace WebVslApiTraining.Features.Product.GetProductById
{
    public class GetProductByIdHandler(AppDbContext context)
        : IRequestHandler<GetProductByIdQuery, GetProductResponse>
    {
        public async Task<GetProductResponse> Handle(GetProductByIdQuery request, 
            CancellationToken cancellationToken)
        {
            var product = await context.Products
                .Include(c => c.Category)
                .FirstOrDefaultAsync( p => p.Id == request.Id, cancellationToken);
            return product.Adapt<GetProductResponse>();
        }
    }
}
