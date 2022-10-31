using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realyst.Core.Models.ProductComment
{
    public class ProductCommentModel
    {
        public int ProductCommentId { get; set; }
        public string ProductComment { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfComment { get; set; }
        public int ProductId { get; set; }
    }
}
