using Core.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IDataSource01Repo
    {
        IEnumerable<ProductTypes> GetAllProductTypes(bool trackChanges);
    }
}
