﻿using System;
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
    public class InvoiceRepository
    {
        public List<Invoice> GetAllInvoices()
        {
            string sql = $"SELECT * FROM {DbTables.Invoice}";
            List<Invoice> invoices = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Invoice
                {
                    Id = reader[InvoiceColumns.Id].ToString(),
                    StaffId = reader[InvoiceColumns.StaffId].ToString(),
                    CardId = reader[InvoiceColumns.CardId] as string,
                    Date = Convert.ToDateTime(reader[InvoiceColumns.Date]),
                    Status = Convert.ToBoolean(reader[InvoiceColumns.Status])
                };
            });
            return invoices;
        }


        // Get invoices by specific criteria (e.g., StaffId, CardId, etc.)
        public List<Invoice> GetInvoicesByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM {DbTables.Invoice} WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Invoice> invoices = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Invoice
                {
                    Id = reader[InvoiceColumns.Id].ToString(),
                    StaffId = reader[InvoiceColumns.StaffId].ToString(),
                    CardId = reader[InvoiceColumns.CardId] as string,
                    Date = Convert.ToDateTime(reader[InvoiceColumns.Date]),
                    Status = Convert.ToBoolean(reader[InvoiceColumns.Status])
                };
            }, parameters);
            return invoices;
        }



        public int Insert(Invoice invoice)
        {
            string sql = $"INSERT INTO {DbTables.Invoice} ({InvoiceColumns.Id}, {InvoiceColumns.StaffId}, " +
                         $"{InvoiceColumns.CardId}, {InvoiceColumns.Date}, {InvoiceColumns.Status}) " +
                         "VALUES (@Id, @StaffId, @CardId, @Date, @Status)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", invoice.Id ?? (object)DBNull.Value),
                new SqlParameter("@StaffId", invoice.StaffId ?? (object)DBNull.Value),
                new SqlParameter("@CardId", invoice.CardId ?? (object)DBNull.Value),
                new SqlParameter("@Date", invoice.Date),
                new SqlParameter("@Status", invoice.Status)
            };

            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        public int Update(Invoice invoice)
        {
            string sql = $"UPDATE {DbTables.Invoice} SET " +
                         $"{InvoiceColumns.StaffId} = @StaffId, " +
                         $"{InvoiceColumns.CardId} = @CardId, " +
                         $"{InvoiceColumns.Date} = @Date, " +
                         $"{InvoiceColumns.Status} = @Status " +
                         $"WHERE {InvoiceColumns.Id} = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", invoice.Id ?? (object)DBNull.Value),
                new SqlParameter("@StaffId", invoice.StaffId ?? (object)DBNull.Value),
                new SqlParameter("@CardId", invoice.CardId ?? (object)DBNull.Value),
                new SqlParameter("@Date", invoice.Date),
                new SqlParameter("@Status", invoice.Status)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        public int Delete(string invoiceId)
        {
            string sql = $"DELETE FROM {DbTables.Invoice} WHERE {InvoiceColumns.Id} = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", invoiceId)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}














//public DataTable GetDetailsByInvoiceId(string invoiceId)
//{
//    string sql = $"SELECT c.*, p.{ProductColumns.ProductName} " +
//                $"FROM {DbTables.InvoiceDetail} c " +
//                $"JOIN {DbTables.Product} p ON c.{ProductColumns.ProductId} = p.{ProductColumns.ProductId} " +
//                $"WHERE c.{InvoiceColumns.Id} = @InvoiceId";

//    SqlParameter[] parameters = new SqlParameter[]
//    {
//                new SqlParameter("@InvoiceId", invoiceId)
//    };

//    return Utilities.ExecuteDataTable(sql, parameters);
//}


//public string GenerateInvoiceId()
//{
//    string prefix = "PBH";
//    string query = $"SELECT {InvoiceColumns.Id} FROM {DbTables.Invoice} ORDER BY {InvoiceColumns.Id} DESC";
//    try
//    {
//        // Get the maximum InvoiceId from the database
//        string lastInvoiceId = Utilities.ExecuteScalar(query)?.ToString() ?? string.Empty;
//        if (string.IsNullOrEmpty(lastInvoiceId))
//        {
//            return prefix + "001";
//        }
//        // Extract the numeric part and increment it
//        string numericPart = lastInvoiceId.Substring(prefix.Length);
//        int nextNumber = int.Parse(numericPart) + 1;
//        return prefix + nextNumber.ToString("D3");
//    }
//    catch (Exception ex)
//    {
//        throw new Exception("Error generating new InvoiceId: " + ex.Message);
//    }
//}