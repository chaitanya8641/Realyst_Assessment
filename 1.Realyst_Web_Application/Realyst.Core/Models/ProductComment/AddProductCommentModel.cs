namespace Realyst.Core.Models.ProductComment
{
    public class AddProductCommentModel
    {
        public string ProductComment { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfComment { get; set; }
        public int ProductId { get; set; }
    }
}
