using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI_UI_PolyCafe
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblContent1.Text = GetPolyCafeMissionContent();
            lblContent2.Text = GetPolyCafeVisionContent();
        }

        private string GetPolyCafeMissionContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Sứ mệnh của chúng tôi: ");
            sb.AppendLine("Cung cấp một giải pháp phần mềm mạnh mẽ cho ");
            sb.AppendLine("chuỗi cửa hàng PolyCafe của Trường FPT Polytechnic,");
            sb.AppendLine("nhằm hợp lý hóa các hoạt động kinh doanh và nâng cao");
            sb.AppendLine("chất lượng dịch vụ cũng như trải nghiệm khách hàng.");
            return sb.ToString();
        }

        private string GetPolyCafeVisionContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("2. Tầm nhìn của chúng tôi: ");
            sb.AppendLine("Trở thành một phần mềm quản lý quán cà phê hàng đầu,");
            sb.AppendLine("được sử dụng rộng rãi trong các chuỗi cửa hàng cà phê ");
            sb.AppendLine("tại Việt Nam,với mục tiêu nâng cao hiệu quả kinh doanh");
            sb.AppendLine("và sự hài lòng của khách hàng.");
            return sb.ToString();
        }
    }
}



//private string GetOperatingMechanismContent()
//{
//    StringBuilder sb = new StringBuilder();
//    sb.AppendLine("3. Cơ chế hoạt động của phần mềm: ");
//    sb.AppendLine("Phần mềm PolyCafe được thiết kế để quản lý các hoạt động ");
//    sb.AppendLine("kinh doanh của chuỗi cửa hàng, bao gồm quản lý đơn hàng, ");
//    sb.AppendLine("thanh toán, tồn kho, và báo cáo doanh thu. Nó cung cấp giao");
//    sb.AppendLine("diện người dùng thân thiện và dễ sử dụng, giúp nhân viên nhanh");
//    sb.AppendLine("chóng nắm bắt và thực hiện các thao tác cần thiết.");
//    return sb.ToString();
//}