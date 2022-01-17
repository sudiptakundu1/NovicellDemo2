using Core.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IDataSource02Repo
    {
        IEnumerable<Products> GetAllProducts(bool trackChanges);
    }
}
