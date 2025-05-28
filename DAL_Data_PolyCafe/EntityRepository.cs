using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DBUTIL_Utilities_PolyCafe;

namespace DAL_Data_PolyCafe
{
    public class EntityRepository
    {
        public DataTable SearchRecords(string tableName, string columnName, string searchValue)
        {
            string query = $"SELECT * FROM {tableName} WHERE {columnName} LIKE @searchValue";
            SqlParameter searchParam = new SqlParameter("@searchValue", "%" + searchValue + "%");

            return Utilities.ExecuteDataTable(query, searchParam);
        }

    }
}
