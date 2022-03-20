using System.ComponentModel;
using System.Data.SqlClient;

namespace BilgeAdam.Sql.ThirdParty.Extensions
{
    public static class BindingListExtensions
    {
        public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                list.Add(item);
            }
        }
    }

    public static class SqlParameterExtensions
    {
        public static List<SqlParameter> Add(this List<SqlParameter> sqlParameters, string name, object value)
        {
            sqlParameters.Add(new SqlParameter(name, value));
            return sqlParameters;
        }
    }
}
