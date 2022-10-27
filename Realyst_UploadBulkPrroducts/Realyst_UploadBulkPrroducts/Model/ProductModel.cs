namespace Realyst_UploadBulkPrroducts.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
