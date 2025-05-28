using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class InvoiceServices
    {
        private readonly InvoiceRepository? invoiceRepository;

        public InvoiceServices()
        {
            invoiceRepository = new InvoiceRepository();
        }

        public List<Invoice> GetAllInvoices()
        {
            return invoiceRepository.GetAllInvoices();
        }
    }
}
