using Contracts;
using Core;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class RepoDataSource02 : RepoBase<DataSource02Context, Products>, IDataSource02Repo
    {
        public RepoDataSource02(DataSource02Context repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Products> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Product)
            .ToList();
    }
}
