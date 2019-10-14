using InterBlock.DataEngine.Common;
using InterBlock.Helpers.Configurations;
using InterBlock.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Repositories.Base
{
    public class ExtendedRepository<T> : DBContextExtendedBase, iRepositoryBase<T> where T : class
    {
        private IBConfiguration _config;

        public ExtendedRepository(IBConfiguration config):base(config)
        {
            _config = config;
        }

        public Task<bool> DeleteMulti(T Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSingle(T Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSingle(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindALLRecords()
        {
            throw new NotImplementedException();
        }

        public Task<T> FindOneRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModifySingle(T Entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveMulti(T Entity, int Action)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveSingle(T Entity, int Action)
        {
            throw new NotImplementedException();
        }
    }
}
