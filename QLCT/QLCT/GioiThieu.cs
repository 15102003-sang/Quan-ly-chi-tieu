using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class GioiThieu : Form
    {
        public GioiThieu()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            Form formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.ShowDialog();
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            Form formDangKi = new FormDangKi();
            formDangKi.ShowDialog();
        }

        private void GioiThieu_Load(object sender, EventArgs e)
        {

        }
    }
}
