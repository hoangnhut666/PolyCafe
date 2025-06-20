using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DAL_Data_PolyCafe.Constants;
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

        public string GenerateStaffId()
        {
            return EntityRepository.GenerateId(DbTables.Staff, StaffColumns.Id, "NV");
        }

        public Staff? GetStaffByCriteria(string columnName, string value)
        {
            var staffList = staffRepository.GetStaffListByCriteria(columnName, value);
            return staffList.FirstOrDefault();
        }

        public List<Staff> GetStaffListByCriteria(string columnName, string value)
        {
            var staffList = staffRepository.GetStaffListByCriteria(columnName, value);
            return staffList;
        }

        // Add a new staff member
        public int AddStaff(Staff staff)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff), "Staff cannot be null.");
            }
            return staffRepository.Insert(staff);
        }

        // Update an existing staff member
        public int UpdateStaff(Staff staff)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff), "Staff cannot be null.");
            }
            return staffRepository.Update(staff);
        }

        // Delete a staff member by ID
        public int DeleteStaff(string staffId)
        {
            if (string.IsNullOrEmpty(staffId))
            {
                throw new ArgumentException("Staff ID cannot be null or empty.", nameof(staffId));
            }
            return staffRepository.Delete(staffId);
        }
    }
}
