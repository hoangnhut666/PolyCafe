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
    public class ReportRepository
    {
        public List<RevenueByCategoryReport> GetRevenueByCategory(string productCategoryId, DateTime fromDate, DateTime toDate)
        {
            string storeProcedureName = "TKDoanhThuTheoLoaiSP";

            List<RevenueByCategoryReport> reports = Utilities.ExecuteStoredProcedure(
                storeProcedureName,
                reader => new RevenueByCategoryReport
                {
                    ProductId = reader["MaSanPham"]?.ToString() ?? string.Empty,
                    ProductName = reader["TenSanPham"]?.ToString() ?? string.Empty,
                    TotalAmount = reader["TongTien"] != DBNull.Value ? Convert.ToDecimal(reader["TongTien"]) : 0,
                    QuantitySold = reader["SoLy"] != DBNull.Value ? Convert.ToInt32(reader["SoLy"]) : 0,
                    SaleDate = reader["NgayBan"] != DBNull.Value ? Convert.ToDateTime(reader["NgayBan"]) : DateTime.MinValue,
                    NumberOfReceipts = reader["SoLuongPhieu"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongPhieu"]) : 0,
                    Status = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : 0
                },
                new SqlParameter("@1", productCategoryId),
                new SqlParameter("@2", fromDate),
                new SqlParameter("@3", toDate)
            );

            return reports;
        }

        //Get GetRevenueByEmployee
        public List<RevenueByEmployeeReport> GetRevenueByEmployee(string employeeId, DateTime fromDate, DateTime toDate)
        {
            string storeProcedureName = "TKDoanhThuTheoNhanVien";
            List<RevenueByEmployeeReport> reports = Utilities.ExecuteStoredProcedure(
                storeProcedureName,
                reader => new RevenueByEmployeeReport
                {
                    EmployeeId = reader["MaNhanVien"]?.ToString() ?? string.Empty,
                    FullName = reader["HoTen"]?.ToString() ?? string.Empty,
                    TotalAmount = reader["TongTien"] != DBNull.Value ? Convert.ToDecimal(reader["TongTien"]) : 0,
                    SaleDate = reader["NgayBan"] != DBNull.Value ? Convert.ToDateTime(reader["NgayBan"]) : DateTime.MinValue,
                    NumberOfReceipts = reader["SoLuongPhieu"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongPhieu"]) : 0,
                    Status = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : 0
                },
                new SqlParameter("@1", employeeId),
                new SqlParameter("@2", fromDate),
                new SqlParameter("@3", toDate)
            );
            return reports;

        }
    }
}




