using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BusinessModels
{
    public class ProductDetails
    {
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
