
using Catalog.Api.Products.CreateProduct;

namespace Catalog.Api.Products.DeleteProduct
{
    public record DeleteProductResponse(bool IsSuccess);

    public class DeleteProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{id}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteProductCommand(id));
                
                var response = result.Adapt<DeleteProductResponse>();

                return Results.Ok(response);   

            })
              .WithName("DeleteProductById")
             .Produces<CreateProductResponse>(StatusCodes.Status201Created)
             .ProducesProblem(StatusCodes.Status400BadRequest)
             .WithSummary("Delete product by id")
             .WithDescription("Delete product by id");
        }
    }
}
