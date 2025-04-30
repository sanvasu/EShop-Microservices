

namespace Catalog.Api.Products.GetProductById
{

    public record GetProductByIDQuery(Guid id) : IQuery<GetProductByIdResult>;

    public record GetProductByIdResult(Product Product);

    internal class GetProductByIdQueryHandler
        (IDocumentSession session, ILogger<GetProductByIdQueryHandler> logger)
        : IQueryHandler<GetProductByIDQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIDQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("Getproductbyidqueryhandler.Handle called with{@Query}", query);

            var product = await session.LoadAsync<Product>(query.id, cancellationToken);

            if(product is null)
            {
                throw new ProductNotFoundException();
            }

            return new GetProductByIdResult(product);
        }
    }
}
