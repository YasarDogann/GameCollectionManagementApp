using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Utilities.Database
{
    // her seferinde nesne oluşturmak yerine böyle bişey yaptık ve birçok kez kullandık
    public class SqlParameterBuilder
    {
        // parametreleri tutacak koleksiyon
        private List<NpgsqlParameter> _parameters = new List<NpgsqlParameter>();

        public SqlParameterBuilder AddParameter(string name, object value)
        {
            _parameters.Add(new NpgsqlParameter(name, value ?? DBNull.Value));
            return this; // nesnenin kendisini döndürüyorum 
        }

        public SqlParameterBuilder AddParameterWithValue(string name, object value, SqlDbType sqlDbType)
        {
            _parameters.Add(new NpgsqlParameter(name, sqlDbType) { Value = value ?? DBNull.Value});
            return this; // nesnenin kendisini döndürüyorum 
        }

        public NpgsqlParameter[] Build()
        {
            return _parameters.ToArray();
        }
    }
}
