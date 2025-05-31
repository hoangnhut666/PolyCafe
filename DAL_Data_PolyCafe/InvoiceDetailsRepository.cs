using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe.Constants;
using DBUTIL_Utilities_PolyCafe;
using DTO_Models_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_Data_PolyCafe
{
    public class InvoiceDetailsRepository
    {

        //Get all invoice details from the database
        public List<InvoiceDetail> GetInvoiceDetails()
        {
            string sql = $"SELECT * FROM {DbTables.InvoiceDetail}";
            List<InvoiceDetail> invoiceDetails = Utilities.ExecuteQuery(sql, reader =>
            {
                return new InvoiceDetail
                {
                    Id = Convert.ToInt32(reader[InvoiceDetailColumns.Id]),
                    InvoiceId = reader[InvoiceDetailColumns.InvoiceId].ToString(),
                    ProductId = reader[InvoiceDetailColumns.ProductId].ToString(),
                    Quantity = Convert.ToInt32(reader[InvoiceDetailColumns.Quantity]),
                    UnitPrice = Convert.ToDecimal(reader[InvoiceDetailColumns.UnitPrice])
                };
            });

            return invoiceDetails;
        }


        //Add a new invoice detail to the database
        public void InsertInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            string sql = $"INSERT INTO {DbTables.InvoiceDetail} ({InvoiceDetailColumns.InvoiceId}, {InvoiceDetailColumns.ProductId}, {InvoiceDetailColumns.Quantity}, {InvoiceDetailColumns.UnitPrice}) " +
                         $"VALUES (@InvoiceId, @ProductId, @Quantity, @UnitPrice)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@InvoiceId", invoiceDetail.InvoiceId),
                new SqlParameter("@ProductId", invoiceDetail.ProductId),
                new SqlParameter("@Quantity", invoiceDetail.Quantity),
                new SqlParameter("@UnitPrice", invoiceDetail.UnitPrice)
            };

            Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Update an existing invoice detail in the database
        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            string sql = $"UPDATE {DbTables.InvoiceDetail} SET " +
                         $"{InvoiceDetailColumns.InvoiceId} = @InvoiceId, " +
                         $"{InvoiceDetailColumns.ProductId} = @ProductId, " +
                         $"{InvoiceDetailColumns.Quantity} = @Quantity, " +
                         $"{InvoiceDetailColumns.UnitPrice} = @UnitPrice " +
                         $"WHERE {InvoiceDetailColumns.Id} = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", invoiceDetail.Id),
                new SqlParameter("@InvoiceId", invoiceDetail.InvoiceId),
                new SqlParameter("@ProductId", invoiceDetail.ProductId),
                new SqlParameter("@Quantity", invoiceDetail.Quantity),
                new SqlParameter("@UnitPrice", invoiceDetail.UnitPrice)
            };
            Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Delete an invoice detail from the database
        public void DeleteInvoiceDetail(int id)
        {
            string sql = $"DELETE FROM {DbTables.InvoiceDetail} WHERE {InvoiceDetailColumns.Id} = @Id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}



//public int Id { get; set; }
//public string? InvoiceId { get; set; }
//public string? ProductId { get; set; }
//public int Quantity { get; set; }
//public decimal UnitPrice { get; set; }