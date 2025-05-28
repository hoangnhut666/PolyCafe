using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class StaffServices
    {
        private readonly StaffRepository staffRepository;

        public StaffServices()
        {
            staffRepository = new StaffRepository();
        }

        public List<Staff> GetAllStaff()
        {
            return staffRepository.GetAll();
        }

        public Staff? GetStaffByCriteria(string columnName, string value)
        {
            var staffList = staffRepository.GetStaffListByCriteria(columnName, value);
            return staffList.FirstOrDefault();
        }
    }
}
