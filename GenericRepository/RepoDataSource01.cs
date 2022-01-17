using Contracts;
using Core;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository
{
    public class RepoDataSource01 : RepoBase<DataSource01Context, ProductTypes>, IDataSource01Repo
    {
        public RepoDataSource01(DataSource01Context repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<ProductTypes> GetAllProductTypes(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.ProductType)
            .ToList();
    }
}
