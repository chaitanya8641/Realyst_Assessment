
namespace Realyst.Core.Models.Product
{
    public class AddProductModel
    {
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class UpdateProductModel : AddProductModel
    {
        public int ProductId { get; set; }
    }
}
