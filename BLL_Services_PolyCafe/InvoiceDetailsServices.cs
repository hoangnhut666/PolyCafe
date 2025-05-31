using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class InvoiceDetailsServices
    {
        private readonly InvoiceDetailsRepository invoiceDetailsRepository;

        public InvoiceDetailsServices()
        {
            invoiceDetailsRepository = new InvoiceDetailsRepository();
        }

        // Get all invoice details
        public List<InvoiceDetail> GetAllInvoiceDetails()
        {
            return invoiceDetailsRepository.GetInvoiceDetails();
        }

        // Add a new invoice detail
        public void AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            invoiceDetailsRepository.InsertInvoiceDetail(invoiceDetail);
        }


        // Update an existing invoice detail
        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            invoiceDetailsRepository.UpdateInvoiceDetail(invoiceDetail);
        }


        // Delete an invoice detail by ID
        public void DeleteInvoiceDetail(int id)
        {
            invoiceDetailsRepository.DeleteInvoiceDetail(id);
        }

    }
}
