using Microsoft.Extensions.Configuration;
using Realyst_UploadBulkPrroducts.Model;
using System.Data.SqlClient;

namespace Realyst_UploadBulkPrroducts.DAL
{
    public class ProductsDAL
    {
        private readonly string _connectionString;
        public ProductsDAL(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public int InsertRecords(List<AddProductModel> productsList)
        {
            var rows = 0;
            try
            {
                using (SqlConnection conn = new(_connectionString))
                {
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        using (SqlCommand cmd = new("INSERT INTO Product([ProductName],[Price],[ReleaseDate])VALUES(@ProductName,@Price,@ReleaseDate)", conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@ProductName", productsList[i].ProductName);
                            cmd.Parameters.AddWithValue("@Price", productsList[i].Price);
                            cmd.Parameters.AddWithValue("@ReleaseDate", productsList[i].ReleaseDate);

                            cmd.ExecuteNonQuery();
                            conn.Close();
                            rows++;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return rows;
        }
    }
}
