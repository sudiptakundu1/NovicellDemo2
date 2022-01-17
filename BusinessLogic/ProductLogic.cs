using BusinessLogic.BusinessModels;
using Contracts;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class ProductLogic : IProductLogic
    {
        private readonly IRepoManager _repository;
        public ProductLogic(IRepoManager repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProductDetails> getAllProducts()
        {
            var productTypes = _repository.ProductTypes.GetAllProductTypes(trackChanges: false);
            var products = _repository.Products.GetAllProducts(trackChanges: false);

            var fullViewData = from pt in productTypes
                               join p in products on pt.ProductTypeId equals p.ProductTypeId
                               select new ProductDetails()
                               {
                                   ProductTypeId = pt.ProductTypeId,
                                   ProductType = pt.ProductType,
                                   ProductId = p.ProductId,
                                   Product = p.Product,
                                   Created = p.Created,
                                   Modified = p.Modified
                               };

            return fullViewData;
        }

        public IEnumerable<ProductDetails> getProductById(int productId)
        {
            var productTypes = _repository.ProductTypes.GetAllProductTypes(trackChanges: false);
            var products = _repository.Products.GetAllProducts(trackChanges: false);

            var fullViewData = from pt in productTypes
                               join p in products.Where(p => p.ProductId == productId) on pt.ProductTypeId equals p.ProductTypeId
                               select new ProductDetails()
                               {
                                   ProductTypeId = pt.ProductTypeId,
                                   ProductType = pt.ProductType,
                                   ProductId = p.ProductId,
                                   Product = p.Product,
                                   Created = p.Created,
                                   Modified = p.Modified
                               };

            return fullViewData;
        }

        public IEnumerable<ProductDetails> getProductByTimeStamp(DateTime timestamp)
        {
            throw new NotImplementedException();
        }
    }
}
