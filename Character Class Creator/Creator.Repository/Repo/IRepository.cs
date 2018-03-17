using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Creator.Repository.Repo
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        int Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        IEnumerable<R> ExecuteQuery<R>(string name, bool? usingTransaction = null, int? timeout = null);

        IEnumerable<R> SingleSetStoredProcedure<R>(string name, DynamicParameters parameters = null, bool? usingTransaction = null, int? timeout = null);

        R MultipleSetStoredProcedure<R>(string name, Func<GridReader, R> func, DynamicParameters parameters = null, bool? usingTransaction = null, int? timeout = null);

    }
}
