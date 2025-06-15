using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class ReportServices
    {
        public ReportRepository ReportRepository { get; set; }
        public ReportServices()
        {
            ReportRepository = new ReportRepository();
        }

        // Get revenue by category
        public List<RevenueByCategoryReport> GetRevenueByCategory(string productCategoryId, DateTime fromDate, DateTime toDate)
        {
            return ReportRepository.GetRevenueByCategory(productCategoryId, fromDate, toDate);
        }

        // Get revenue by employee
        public List<RevenueByEmployeeReport> GetRevenueByEmployee(string employeeId, DateTime fromDate, DateTime toDate)
        {
            return ReportRepository.GetRevenueByEmployee(employeeId, fromDate, toDate);
        }
    }
}
