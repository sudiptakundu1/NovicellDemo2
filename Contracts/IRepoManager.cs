using System;

namespace Contracts
{
    public interface IRepoManager
    {
        IDataSource01Repo ProductTypes { get; }
        IDataSource02Repo Products { get; }
    }
}
