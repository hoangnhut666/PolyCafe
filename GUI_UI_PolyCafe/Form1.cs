using BLL_Services_PolyCafe;

namespace GUI_UI_PolyCafe
{
    public partial class Form1 : Form
    {
        private readonly InvoiceServices invoiceServices;
        private readonly StaffServices staffServices;
        public Form1()
        {
            InitializeComponent();
            invoiceServices = new InvoiceServices();
            staffServices = new StaffServices();
            dataGridView1.DataSource = invoiceServices.GetAllInvoices();
            dataGridView2.DataSource = staffServices.GetAllStaff();
        }
    }
}
