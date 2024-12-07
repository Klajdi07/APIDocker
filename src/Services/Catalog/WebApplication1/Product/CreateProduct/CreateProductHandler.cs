using BuildingBlocks.CQRS;
using WebApplication1.Models;

namespace WebApplication1.Product.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        :ICommand<CreateProductResult>;

    public record CreateProductResult(Guid Id);
    internal class CreateProducCommandtHandler 
     : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        //Create product entity from command object
        //save to database
        //return result
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new WebApplication1.Models.Product
            {
                Name = command.Name,
                Categpry = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
