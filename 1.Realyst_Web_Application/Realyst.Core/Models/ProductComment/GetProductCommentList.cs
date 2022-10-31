namespace Realyst.Core.Models.ProductComment
{
    public class GetProductCommentList
    {
        public int ProductCommentId { get; set; }
        public string ProductComment { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfComment { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
