using Contracts;
using Core;
using Core.Models;
using System;

namespace GenericRepository
{
    public class RepoManager : IRepoManager
    {
        private DataSource01Context _repoDataSource01Context;
        private DataSource02Context _repoDataSource02Context;

        private IDataSource01Repo _DataSource01Repo;
        private IDataSource02Repo _DataSource02Repo;

        public RepoManager(DataSource01Context repoDataSource01Context, DataSource02Context repoDataSource02Context)
        {
            _repoDataSource01Context = repoDataSource01Context;
            _repoDataSource02Context = repoDataSource02Context;
        }

        public IDataSource01Repo ProductTypes
        {
            get
            {
                if (_DataSource01Repo is null)
                    _DataSource01Repo = new RepoDataSource01(_repoDataSource01Context);

                return _DataSource01Repo;
            }
        }

        public IDataSource02Repo Products
        {
            get
            {
                if (_DataSource02Repo is null)
                    _DataSource02Repo = new RepoDataSource02(_repoDataSource02Context);

                return _DataSource02Repo;
            }
        }
    }
}
