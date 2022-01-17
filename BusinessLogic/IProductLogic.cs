using BusinessLogic.BusinessModels;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IProductLogic
    {
        public IEnumerable<ProductDetails> getAllProducts();
        public IEnumerable<ProductDetails> getProductById(int productId);
        public IEnumerable<ProductDetails> getProductByTimeStamp(DateTime timestamp);

    }
}
