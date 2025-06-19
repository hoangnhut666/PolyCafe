using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DBUTIL_Utilities_PolyCafe
{
    public class Utilities
    {
        private static readonly string connString = @"Server=.\;Database=PolyCafe;Integrated Security=True;TrustServerCertificate=True;";

        public static List<T> ExecuteQuery<T>(string query, Func<IDataReader, T> mapFunction, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(mapFunction(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing query and mapping results: {query}", ex);
                }
            }

            return result;
        }


        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                try
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing non-query command: {commandText}", ex);
                }
            }
        }


        public static object ExecuteScalar(string commandText, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                try
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing scalar command: {commandText}", ex);
                }
            }
        }


        public static List<T> ExecuteStoredProcedure<T>(string storedProcedureName, Func<IDataReader, T> mapFunction, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(mapFunction(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing stored procedure: {storedProcedureName}", ex);
                }
            }

            return result;
        }
    }
}




































































//    /// <summary>
//    /// A static class to simplify interaction with SQL Server using ADO.NET.
//    /// </summary>
//    public static class SqlUtilities
//    {
//        // Replace these values with your actual SQL Server connection details.
//        private static readonly string ConnectionString =
//            @"Server=.\;Database=PolyCafe;Integrated Security=True;TrustServerCertificate=True;";

//        /// <summary>
//        /// Executes a non-query T-SQL command (such as INSERT, UPDATE or DELETE).
//        /// </summary>
//        /// <param name="commandText">The T-SQL command or stored procedure to execute.</param>
//        /// <param name="parameters">Optional SQL parameters for the command.</param>
//        /// <returns>The number of rows affected.</returns>
//        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
//        {
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            using (SqlCommand command = new SqlCommand(commandText, connection))
//            {
//                if (parameters != null)
//                {
//                    command.Parameters.AddRange(parameters);
//                }

//                connection.Open();
//                return command.ExecuteNonQuery();
//            }
//        }

//        /// <summary>
//        /// Executes a T-SQL command that returns a single scalar value.
//        /// </summary>
//        /// <param name="commandText">The T-SQL command or stored procedure to execute.</param>
//        /// <param name="parameters">Optional SQL parameters for the command.</param>
//        /// <returns>The first column of the first row in the result set.</returns>
//        public static object ExecuteScalar(string commandText, params SqlParameter[] parameters)
//        {
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            using (SqlCommand command = new SqlCommand(commandText, connection))
//            {
//                if (parameters != null)
//                {
//                    command.Parameters.AddRange(parameters);
//                }

//                connection.Open();
//                return command.ExecuteScalar();
//            }
//        }

//        /// <summary>
//        /// Executes a T-SQL query and returns the result in a DataTable.
//        /// </summary>
//        /// <param name="commandText">The T-SQL query to execute.</param>
//        /// <param name="parameters">Optional SQL parameters for the query.</param>
//        /// <returns>A DataTable containing the results of the query.</returns>
//        public static DataTable ExecuteDataTable(string commandText, params SqlParameter[] parameters)
//        {
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            using (SqlCommand command = new SqlCommand(commandText, connection))
//            {
//                if (parameters != null)
//                {
//                    command.Parameters.AddRange(parameters);
//                }

//                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
//                {
//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    return dt;
//                }
//            }
//        }

//        /// <summary>
//        /// Executes a T-SQL query and returns a SqlDataReader.
//        /// </summary>
//        /// <param name="commandText">The T-SQL query to execute.</param>
//        /// <param name="parameters">Optional SQL parameters for the query.</param>
//        /// <returns>A SqlDataReader object for reading the results. Note that the caller is responsible for closing it.</returns>
//        public static SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parameters)
//        {
//            SqlConnection connection = new SqlConnection(ConnectionString);
//            SqlCommand command = new SqlCommand(commandText, connection);

//            if (parameters != null)
//            {
//                command.Parameters.AddRange(parameters);
//            }

//            connection.Open();
//            // Use the CloseConnection behavior so that when the reader is closed, the connection is also closed.
//            return command.ExecuteReader(CommandBehavior.CloseConnection);
//        }
//    }
//}


//public static DataTable ExecuteDataTable(string commandText, params SqlParameter[] parameters)
//{
//    using (SqlConnection connection = new SqlConnection(connString))
//    using (SqlCommand command = new SqlCommand(commandText, connection))
//    {
//        try
//        {
//            if (parameters != null)
//            {
//                command.Parameters.AddRange(parameters);
//            }

//            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
//            {
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);
//                return dt;
//            }
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error executing DataTable query: {commandText}", ex);
//        }
//    }
//}





























//public static int Update(string sql, List<SqlParameter>? parameters = null, CommandType cmdType = CommandType.Text)
//{
//    using (SqlConnection conn = new SqlConnection(connString))
//    {
//        conn.Open();
//        SqlTransaction transaction = conn.BeginTransaction();

//        try
//        {
//            using (SqlCommand cmd = GetCommand(sql, cmdType, parameters))
//            {
//                cmd.Connection = conn;
//                cmd.Transaction = transaction;

//                int affectedRows = cmd.ExecuteNonQuery();
//                transaction.Commit();

//                return affectedRows;
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error in Update: {ex.Message}");
//            transaction.Rollback();
//            return -1;
//        }
//    }
//}




//public static DataTable? Query(string sql, List<SqlParameter>? parameters = null, CommandType cmdType = CommandType.Text)
//{
//    try
//    {
//        using (SqlConnection conn = new SqlConnection(connString))
//        using (SqlCommand cmd = GetCommand(sql, CommandType.Text, parameters))
//        {
//            cmd.CommandType = cmdType;
//            if (parameters != null)
//                cmd.Parameters.AddRange(parameters.ToArray());

//            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
//            {
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                return dt;
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error in Query: {ex.Message}");
//        return null;
//    }
//}



//public static object? Value(string sql, List<SqlParameter>? parameters = null, CommandType cmdType = CommandType.Text)
//{
//    try
//    {
//        using (SqlConnection conn = new SqlConnection(connString))
//        using (SqlCommand cmd = new SqlCommand(sql, conn))
//        {
//            cmd.CommandType = cmdType;
//            if (parameters != null)
//                cmd.Parameters.AddRange(parameters.ToArray());

//            conn.Open();
//            return cmd.ExecuteScalar();
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error in Value: {ex.Message}");
//        return null;
//    }
//}









//private static SqlCommand GetCommand(string sql, CommandType cmdType, List<SqlParameter>? parameters = null)
//{
//    SqlConnection conn = new SqlConnection(connString);
//    SqlCommand cmd = new SqlCommand(sql, conn);
//    cmd.CommandType = cmdType;

//    if (parameters != null)
//    {
//        cmd.Parameters.AddRange(parameters.ToArray());
//    }

//    return cmd;
//}

//public static void Update(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
//{
//    SqlCommand cmd = GetCommand(sql, cmdType);
//    cmd.Connection.Open();
//    cmd.Transaction = cmd.Connection.BeginTransaction();
//    try
//    {
//        cmd.ExecuteNonQuery();
//        cmd.Transaction.Commit();
//    }
//    catch (Exception)
//    {
//        cmd.Transaction.Rollback();
//        Console.WriteLine($"Error in Update: {sql}");
//        throw;
//    }
//}


//public static SqlDataReader Query(string sql, List<SqlParameter>? parameters = null, CommandType cmdType = CommandType.Text)
//{
//    try
//    {
//        SqlCommand cmd = GetCommand(sql, cmdType, parameters);
//        cmd.Connection.Open();
//        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error in Query: {ex.Message}");
//        throw;
//    }
//}




//public static Object Value(string sql, List<object> args, CommandType cmdType = CommandType.Text)
//{
//    try
//    {
//        SqlCommand cmd = GetCommand(sql, cmdType);
//        using (cmd.Connection)
//        {
//            cmd.Connection.Open();
//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                Object result = new object();

//                if (reader.Read())
//                {
//                    for (int i = 0; i < reader.FieldCount; i++)
//                    {
//                        string columnName = reader.GetName(i);
//                        PropertyInfo propertyInfo = result.GetType().GetProperty(columnName);

//                        if (propertyInfo != null)
//                        {
//                            var value = reader.IsDBNull(i) ? null : reader[columnName];
//                            propertyInfo.SetValue(result, value);
//                        }
//                    }
//                }
//                return result;
//            }
//        }
//    }
//    catch (Exception)
//    {
//        Console.WriteLine($"Error in Value: {sql}");
//        throw;
//    }
//}