using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe.Constants;
using DTO_Models_PolyCafe;
using Microsoft.Data.SqlClient;
using DBUTIL_Utilities_PolyCafe;

namespace DAL_Data_PolyCafe
{
    public class StaffRepository
    {
        public List<Staff> GetAll()
        {
            string sql = $"SELECT * FROM {DbTables.Staff}";
            List<Staff> staff = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Staff
                {
                    Id = reader[StaffColumns.Id].ToString(),
                    FullName = reader[StaffColumns.FullName].ToString(),
                    Email = reader[StaffColumns.Email].ToString(),
                    Password = reader[StaffColumns.Password].ToString(),
                    Role = Convert.ToInt32(reader[StaffColumns.Role]),
                    Status = Convert.ToInt32(reader[StaffColumns.Status])
                };
            });

            return staff;
        }


        public List<Staff> GetStaffListByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM {DbTables.Staff} WHERE {columnName} = @Value";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };

            List<Staff> staff = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Staff
                {
                    Id = reader[StaffColumns.Id].ToString(),
                    FullName = reader[StaffColumns.FullName].ToString(),
                    Email = reader[StaffColumns.Email].ToString(),
                    Password = reader[StaffColumns.Password].ToString(),
                    Role = Convert.ToInt32(reader[StaffColumns.Role]),
                    Status = Convert.ToInt32(reader[StaffColumns.Status])
                };
            }, parameters);

            return staff;
        }



        public bool UpdatePassword(string staffId, string newPassword)
        {
            string sql = $"UPDATE {DbTables.Staff} SET {StaffColumns.Password} = @Password " +
                         $"WHERE {StaffColumns.Id} = @Id";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", newPassword),
                new SqlParameter("@Id", staffId)
            };

            return Utilities.ExecuteNonQuery(sql, parameters) > 0;
        }


        public int Insert(Staff staff)
        {
            string sql = $"INSERT INTO {DbTables.Staff} " +
                         $"({StaffColumns.Id}, {StaffColumns.FullName}, {StaffColumns.Email}, " +
                         $"{StaffColumns.Password}, {StaffColumns.Role}, {StaffColumns.Status}) " +
                         $"VALUES (@Id, @FullName, @Email, @Password, @Role, @Status)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", staff.Id),
                new SqlParameter("@FullName", staff.FullName),
                new SqlParameter("@Email", staff.Email),
                new SqlParameter("@Password", staff.Password),
                new SqlParameter("@Role", staff.Role),
                new SqlParameter("@Status", staff.Status)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        public int Update(Staff staff)
        {
            string sql = $"UPDATE {DbTables.Staff} SET " +
                         $"{StaffColumns.FullName} = @FullName, " +
                         $"{StaffColumns.Email} = @Email, " +
                         $"{StaffColumns.Password} = @Password, " +
                         $"{StaffColumns.Role} = @Role, " +
                         $"{StaffColumns.Status} = @Status " +
                         $"WHERE {StaffColumns.Id} = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", staff.Id),
                new SqlParameter("@FullName", staff.FullName),
                new SqlParameter("@Email", staff.Email),
                new SqlParameter("@Password", staff.Password),
                new SqlParameter("@Role", staff.Role),
                new SqlParameter("@Status", staff.Status)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        public int Delete(string staffId)
        {
            string sql = $"DELETE FROM {DbTables.Staff} WHERE {StaffColumns.Id} = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", staffId)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}



























//public List<Invoice> GetAll()
//{
//    string sql = $"SELECT * FROM {DbTables.Invoice}";

//    DataTable dt = Utilities.Query(sql);
//    List<Invoice> invoices = new List<Invoice>();

//    foreach (DataRow row in dt.Rows)
//    {
//        invoices.Add(new Invoice
//        {
//            Id = row[InvoiceColumns.Id].ToString(),
//            StaffId = row[InvoiceColumns.StaffId].ToString(),
//            CardId = row[InvoiceColumns.CardId]?.ToString(),
//            Date = Convert.ToDateTime(row[InvoiceColumns.Date]),
//            Status = Convert.ToBoolean(row[InvoiceColumns.Status])
//        });
//    }

//    return invoices;
//}




//public Staff? GetById(string staffId)
//{
//    string sql = $"SELECT * FROM {DbTables.Staff} WHERE {StaffColumns.Id} = @Id";

//    var parameters = new SqlParameter[]
//    {
//                new SqlParameter("@Id", staffId)
//    };

//    DataTable? dt = Utilities.ExecuteDataTable(sql, parameters);

//    if (dt != null && dt.Rows.Count > 0)
//    {
//        DataRow row = dt.Rows[0];
//        return new Staff
//        {
//            Id = row[StaffColumns.Id].ToString(),
//            FullName = row[StaffColumns.FullName].ToString(),
//            Email = row[StaffColumns.Email].ToString(),
//            Password = row[StaffColumns.Password].ToString(),
//            Role = Convert.ToInt32(row[StaffColumns.Role])
//        };
//    }

//    return null;
//}

////Search staff by email
//public Staff? SearchStaffByEmail(string email)
//{
//    string sql = $"SELECT * FROM {DbTables.Staff} WHERE {StaffColumns.Email} = @Email";

//    var parameters = new SqlParameter[]
//    {
//                new SqlParameter("@Email", email)
//    };

//    DataTable? dt = Utilities.ExecuteDataTable(sql, parameters);

//    if (dt != null && dt.Rows.Count > 0)
//    {
//        DataRow row = dt.Rows[0];
//        return new Staff
//        {
//            Id = row[StaffColumns.Id].ToString(),
//            FullName = row[StaffColumns.FullName].ToString(),
//            Email = row[StaffColumns.Email].ToString(),
//            Password = row[StaffColumns.Password].ToString(),
//            Role = Convert.ToInt32(row[StaffColumns.Role])
//        };
//    }

//    return null;
//}