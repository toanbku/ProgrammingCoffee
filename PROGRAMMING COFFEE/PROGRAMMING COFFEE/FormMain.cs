using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMMING_COFFEE
{
    public partial class FormMain : Form
    {
        public static bool chuachonmon = true;
        public static Dictionary<string,KhachHang> khach = null;
        public static Dictionary<string,List<DoUong>> danhsach = null;
        public static string soban = "";
        public static string tenkhach = "";
        public static bool chuadangnhap = true;
        
        private UCThanhToan tt = null;
        private UCDangKy dk = null;
        private UCDangNhap dn = null;
        private UCDatban db = null;
        private UCMenu mn = null;
        public UCThungan tn = null;
        public bool home = true;

        public void load_Customer()
        {
            //this.home = false;
            //this.panel1.Controls.Clear();
            //this.panelForm.Controls.Clear();
            //this.panel1.Controls.Add(this.n_ButtonDatBan);
            //this.n_ButtonDatBan.Dock = DockStyle.Top;
            //this.panel1.Controls.Add(this.btnTaiKhoan);
            //this.btnTaiKhoan.Dock = DockStyle.Top;
            //this.panel1.Controls.Add(this.n_ButtonMenu);
            //this.n_ButtonMenu.Dock = DockStyle.Top;
            //this.panel1.Controls.Add(this.btnThanhToan);
            //this.btnThanhToan.Dock = DockStyle.Top;
            //chuachonmon = true;
            //tt.tongTien = 0;


            this.home = false;
            this.panel1.Controls.Clear();
            this.panelForm.Controls.Clear();
           
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.btnTaiKhoan.Dock = DockStyle.Top;
          
            this.panel1.Controls.Add(this.btnThanhToan);
            this.btnThanhToan.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonMenu);
            this.n_ButtonMenu.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonDatBan);
            this.n_ButtonDatBan.Dock = DockStyle.Top;
            chuachonmon = true;
            tt.tongTien = 0;
        }

        public void load_Owner()
        {
            this.home = false;
            this.panel1.Controls.Clear();
            this.panelForm.Controls.Clear();
            this.panel1.Controls.Add(this.btnTinhLuong);
            this.btnTinhLuong.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.btnThuChi);
            this.btnThuChi.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.btnChamCong);
            this.btnChamCong.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.btnThongKe);
            this.btnThongKe.Dock = DockStyle.Top;
        }

        public void load_Cashier()
        {
            tn.banttien = "";
            tn.tenkh = "";
            tn.TongTien = 0;
            this.home = false;  
            this.panel1.Controls.Clear();
            this.panelForm.Controls.Clear();
            this.panel1.Controls.Add(this.btnQLBan);
            this.btnQLBan.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.btnTinhTien);
            this.btnTinhTien.Dock = DockStyle.Top;
            this.panelForm.Controls.Add(tn);
            UCThungan.LoadTrangThai();
        }

        public void load_PhaChe()
        {
            this.home = false;
            this.panel1.Controls.Clear();
            this.panelForm.Controls.Clear();
            this.panel1.Controls.Add(this.btnPhaChe);
            this.btnPhaChe.Dock = DockStyle.Top;
            tenkhach = "";
        }

        public FormMain()
        {
            InitializeComponent();
            khach = new Dictionary<string,KhachHang>();
            danhsach = new Dictionary<string, List<DoUong>>();
            tt = new UCThanhToan();
            dk = new UCDangKy();
            dn = new UCDangNhap();
            db = new UCDatban();
            mn = new UCMenu();
            tn = new UCThungan();
            this.dn.parentForm = this;
            this.dk.parentForm = this;

            this.panelForm.Controls.Clear();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(this.n_ButtonDangki);
            this.n_ButtonDangki.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonDangNhap);
            this.n_ButtonDangNhap.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonDatBan);
            this.n_ButtonDatBan.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonMenu);
            this.n_ButtonMenu.Dock = DockStyle.Top;

            this.panelForm.Controls.Add(new UCMenuChinh());
        }

        internal void n_ButtonDangNhap_Click()
        {
            throw new NotImplementedException();
        }

        private void n_ButtonMenu_Click(object sender, EventArgs e)
        {
            if (chuadangnhap) { MessageBox.Show("Đăng Nhập Để Gọi món"); return; }
         
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(mn);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void n_ButtonDatBan_Click(object sender, EventArgs e)
        {
            if (chuadangnhap) { MessageBox.Show("Đăng Nhập Để Sử Dụng Dịch Vụ");return; }
           
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(db);
        }

        private void n_ButtonThanhtoan_Click(object sender, EventArgs e)
        {
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(tt);
            tt.refresh();
        }

        private void n_ButtonDangNhap_Click(object sender, EventArgs e)
        {

            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(dn);
        }

        public void n_ButtonDangki_Click(object sender, EventArgs e)
        {
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(dk);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (this.home) return;
            this.panelForm.Controls.Clear();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(this.n_ButtonDangki);
            this.n_ButtonDangki.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonDangNhap);
            this.n_ButtonDangNhap.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonDatBan);
            this.n_ButtonDatBan.Dock = DockStyle.Top;
            this.panel1.Controls.Add(this.n_ButtonMenu);
            this.n_ButtonMenu.Dock = DockStyle.Top;
            this.panelForm.Controls.Add(new UCMenuChinh());
            this.home = true;
            chuachonmon = true;
            chuadangnhap = true;
            
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            UCThungan.LoadTrangThai();
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(tn);
        }
    }
}
