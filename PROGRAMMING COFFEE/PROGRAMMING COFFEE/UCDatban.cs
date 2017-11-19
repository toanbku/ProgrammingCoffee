using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace PROGRAMMING_COFFEE
{
    public partial class UCDatban : UserControl
    {
        //public FormMain parentForm { get; set; }
        public UCDatban()
        {
            InitializeComponent();
        }

        private void UCDatban_Load(object sender, EventArgs e)
        {

        }

        private void ChonBan(ref BunifuTileButton b,string tenban) {
            DialogResult traloi;
            traloi = MessageBox.Show("Xác Nhận?", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                FormMain.soban = tenban;
                KhachHang kh = new KhachHang();
                kh.TenBan = tenban;
                kh.TenKhachHang = FormMain.tenkhach;
                kh.goiMon = !FormMain.chuachonmon;
                FormMain.khach.Add(FormMain.tenkhach,kh);
                b.Enabled = false;
            }
        }
        private void n_ButtonTM1_Click(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM1,"TM1");
        }

        private void n_ButtonTM2_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM2, "TM2");
        }

        private void n_ButtonTM3_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM3, "TM3");
        }

        private void n_ButtonTM4_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM4, "TM4");
        }

        private void n_ButtonTM5_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM5, "TM5");
        }

        private void n_ButtonTM6_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM6, "TM6");
        }

        private void n_ButtonTH1_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH1, "TH1");
        }

        private void n_ButtonTH2_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH2, "TH2");
        }

        private void n_ButtonTH3_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH3, "TH3");
        }

        private void n_ButtonTH4_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH4, "TH4");
        }

        private void n_ButtonTH5_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH5, "TH5");
        }

        private void n_ButtonTH6_Click_1(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH6, "TH6");
        }

      
        private void n_ButtonTM7_Click(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM7, "TM7");
        }

        private void n_ButtonTM8_Click(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM8, "TM8");
        }

        private void n_ButtonTH7_Click(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTH7, "TH7");
        }

        private void n_ButtonTH8_Click(object sender, EventArgs e)
        {
            ChonBan(ref this.n_ButtonTM7, "TM7");
        }
    }
}
