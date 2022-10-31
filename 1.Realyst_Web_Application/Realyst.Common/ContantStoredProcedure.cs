namespace Realyst.Common
{
    public class ContantStoredProcedure
    {
        // Products Stored Procedure
        public const string GetProductsListStoredProcedure = "spGetProductsList";
        public const string GetProductByProductIdStoredProcedure = "spGetProductByProductId";
        public const string AddProductStoredProcedure = "spAddProduct";
        public const string UpdateProductStoredProcedure = "spUpdateProduct";
        public const string DeleteProductStoredProcedure = "spDeleteProduct";

        // Product Comments Stored Procedure
        public const string GetCommentsByProductIdStoredProcedure = "spGetCommentsByProductId";
        public const string AddCommentStoredProcedure = "spAddProductComment";
    }
}
