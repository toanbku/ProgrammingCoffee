using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMMING_COFFEE
{
    public partial class UCThanhToan : UserControl
    {
        //public FormMain parentForm { get; set; }
        public int tongTien = 0;
        public UCThanhToan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void n_Call_Click(object sender, EventArgs e)
        {
            if (!FormMain.khach.ContainsKey(FormMain.tenkhach)) { return; }
            DialogResult traloi;
            traloi = MessageBox.Show("Nếu xác nhận yêu cầu sẽ được gửi tới thu ngân", "Xác Nhận <OK>",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (traloi == DialogResult.OK)
            {
                FormMain.khach[FormMain.tenkhach].thanhToan = true;
            }
        }
        public static void ShowListView(ref List<DoUong> du,ref int tongtien,ref ListView ls) {
            ls.Clear();
            ls.Columns.Add("STT", 50);
            ls.Columns.Add("Tên Thức Uống", 150);
            ls.Columns.Add("Đơn Giá", 100);
            ls.Columns.Add("Số Lượng", 100);
            ls.Columns.Add("Thành Tiền", 100);
            for (int i = 0; i < du.Count; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(du[i].Ten);
                item.SubItems.Add(du[i].giaTien.ToString() + ".000");
                item.SubItems.Add(du[i].soLuong.ToString());
                int thanhtien = du[i].giaTien * du[i].soLuong;
                tongtien += thanhtien;
                item.SubItems.Add(thanhtien + ".000");
                ls.Items.Add(item);
            }

        }

        public void refresh() {

            if (!FormMain.khach.ContainsKey(FormMain.tenkhach))
            {
                MessageBox.Show("Ban Chua Dat Ban"); return;
            }
            if (!FormMain.khach[FormMain.tenkhach].goiMon)
            {
                MessageBox.Show("Ban Chua Goi Mon"); return;
            }

            List<DoUong> du = null;
            try
            {
                du = FormMain.danhsach[FormMain.soban];
            }
            catch { return; }

            ShowListView(ref du, ref tongTien, ref listView1);
            bunifuCustomLabel3.Text = " Tổng tiền : " + tongTien.ToString() + ".000 vnđ";
        }
        private void UCThanhToan_Load(object sender, EventArgs e)
        {
            if (!FormMain.khach.ContainsKey(FormMain.tenkhach)) {
                MessageBox.Show("Ban Chua Dat Ban"); return; }
            if (!FormMain.khach[FormMain.tenkhach].goiMon) {
                MessageBox.Show("Ban Chua Goi Mon"); return; }
            
            List<DoUong> du = null;
            try
            {
                du = FormMain.danhsach[FormMain.soban];
            }
            catch { return; }

            ShowListView(ref du, ref tongTien, ref listView1);
            bunifuCustomLabel3.Text = " Tổng tiền : " + tongTien.ToString() + ".000 vnđ";
            
        }
    }
}
