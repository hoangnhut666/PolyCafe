using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_UI_PolyCafe
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblContent1.Text = GetPolyHelpContent();
            lblContent2.Text = GetPolyContactContent();
        }


        private string GetPolyHelpContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hướng dẫn sử dụng phần mềm PolyCafe:");
            sb.AppendLine("1. Đăng nhập vào hệ thống bằng tài khoản của bạn.");
            sb.AppendLine("2. Sử dụng các chức năng quản lý đơn hàng, thanh toán,...");
            sb.AppendLine("3. Xem báo cáo doanh thu và thống kê hoạt động kinh doanh.");
            sb.AppendLine("4. Liên hệ với bộ phận hỗ trợ nếu gặp vấn đề hoặc cần trợ giúp.");

            return sb.ToString();
        }

        private string GetPolyContactContent() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Thông tin liên hệ hỗ trợ:");
            sb.AppendLine("Người hướng dẫn: Võ Thị Hồng Đoan");
            sb.AppendLine("Email: hdvt@yahoo.com");
            sb.AppendLine("Số điện thoại: 0123456789");

            return sb.ToString();
        }
    }
}
