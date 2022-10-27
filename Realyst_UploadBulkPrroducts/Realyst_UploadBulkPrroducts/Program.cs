using Realyst_UploadBulkPrroducts.DAL;
using Microsoft.Extensions.Configuration;
using Realyst_UploadBulkPrroducts.Model;
using System.Globalization;

namespace Realyst_UploadBulkPrroducts
{
    class Program
    {
        private static IConfiguration? _iconfiguration;

        static void Main(string[] args)
        {
            try
            {
                GetAppSettingsFile();
                var totalCommondata = new List<AddProductModel>();
                Console.WriteLine("Please enter the full path of the excel worksheet you would like to store in a database.");
                string excelFile = Console.ReadLine();
                var data = File.ReadAllLines(excelFile);
                for (int i = 1; i < data.Length; i++)
                {
                    var MemberNames = data[i].Split(',');
                    var commonData = new AddProductModel
                    {
                        ProductName = Convert.ToString(MemberNames[1]),
                        Price = (decimal)CustomParse(MemberNames[2]),
                        ReleaseDate = Convert.ToDateTime(MemberNames[3])
                    };

                    totalCommondata.Add(commonData);
                }


                var productDAL = new ProductsDAL(_iconfiguration);
                var insertedRecords = productDAL.InsertRecords(totalCommondata);
                Console.WriteLine("Toal Insert Records : {0}", insertedRecords);
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static decimal? CustomParse(string? incomingValue)
        {
            if (!decimal.TryParse(incomingValue.Replace(",", "").Replace(".", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal val))
                return null;
            return val / 100;
        }

        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
    }
}