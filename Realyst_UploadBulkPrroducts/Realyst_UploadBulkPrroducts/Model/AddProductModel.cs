using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realyst_UploadBulkPrroducts.Model
{
    public class AddProductModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
