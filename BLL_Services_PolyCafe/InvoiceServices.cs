using DAL_Data_PolyCafe;
using DAL_Data_PolyCafe.Constants;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class InvoiceServices
    {
        private readonly InvoiceRepository invoiceRepository;

        public InvoiceServices()
        {
            invoiceRepository = new InvoiceRepository();
        }

        public List<Invoice> GetAllInvoices()
        {
            return invoiceRepository.GetAllInvoices();
        }

        //Get all invoices by StaffId
        public List<Invoice> GetInvoicesByStaffId(string staffId)
        {
            if (string.IsNullOrEmpty(staffId))
            {
                throw new ArgumentException("Staff ID cannot be null or empty.", nameof(staffId));
            }
            return invoiceRepository.GetInvoicesByCriteria(InvoiceColumns.StaffId, staffId);
        }

        // Generate a new invoice ID
        public string GenerateInvoiceId()
        {
            return EntityRepository.GenerateId(DbTables.Invoice,InvoiceColumns.Id, "PBH");
        }

        // Get list of invoice by criteria such as StaffId, CardId, etc.
        public List<Invoice> GetInvoicesByCriteria(string columnName, string value)
        {
            return invoiceRepository.GetInvoicesByCriteria(columnName, value);
        }


        // Insert a new invoice into the database
        public int AddInvoice(Invoice invoice)
        {
            return invoiceRepository.Insert(invoice);
        }

        //Update an existing invoice in the database
        public int UpdateInvoice(Invoice invoice)
        {
            return invoiceRepository.Update(invoice);
        }

        // Delete an invoice by ID
        public int DeleteInvoice(string invoiceId)
        {
            if (string.IsNullOrEmpty(invoiceId))
            {
                throw new ArgumentException("Invoice ID cannot be null or empty.", nameof(invoiceId));
            }
            return invoiceRepository.Delete(invoiceId);
        }
    }

}
