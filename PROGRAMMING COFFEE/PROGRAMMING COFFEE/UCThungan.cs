using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROGRAMMING_COFFEE
{
    public partial class UCThungan : UserControl
    {
        //public FormMain parentForm = null;
        //public UCMenu menu { get; set; }
        public static Dictionary<string, Button> btn = new Dictionary<string, Button>();
        public string banttien = "";
        public string tenkh = "";
        public int TongTien;

        public UCThungan()
        {
            InitializeComponent();

            btn.Add("TM1", TM1); btn.Add("TH1", TH1);
            btn.Add("TM2", TM2); btn.Add("TH2", TH2);
            btn.Add("TM3", TM3); btn.Add("TH3", TH3);
            btn.Add("TM4", TM4); btn.Add("TH4", TH4);
            btn.Add("TM5", TM5); btn.Add("TH5", TH5);
            btn.Add("TM6", TM6); btn.Add("TH6", TH6);
            btn.Add("TM7", TM7); btn.Add("TH7", TH7);
            btn.Add("TM8", TM8); btn.Add("TH8", TH8);
            LoadTrangThai();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCThungan_Load(object sender, EventArgs e)
        {


        }
        public static void LoadTrangThai()
        {
            for (int i = 1; i < 9; i++)
            {
                btn["TM" + i].BackColor = Color.Green;
                btn["TH" + i].BackColor = Color.Green;
            }
            foreach (KeyValuePair<string, KhachHang> entry in FormMain.khach)
            {
                if (entry.Value.thanhToan == true)
                {
                    btn[entry.Value.TenBan].BackColor = Color.Red;
                }
                else
                {
                    btn[entry.Value.TenBan].BackColor = Color.Yellow;
                }
                // do something with entry.Value or entry.Key
            }
        }
        private void ThanhToan(string ban)
        {
            banttien = ban;
            foreach (KeyValuePair<string, KhachHang> entry in FormMain.khach)
            {
                if (String.Compare(entry.Value.TenBan, ban) == 0)
                {
                    tenkh = entry.Key;
                    break;
                }
            }
            if (tenkh == "") { MessageBox.Show("Bàn đang trống"); return; }
            if (!FormMain.danhsach.ContainsKey(ban))
            {
                MessageBox.Show("Ban chua Goi mon"); return;
            }

            if (!FormMain.khach[tenkh].thanhToan)
            {
                MessageBox.Show("Ban chua yeu cau thanh toan"); return;
            }

            List<DoUong> du = FormMain.danhsach[ban];
            UCThanhToan.ShowListView(ref du, ref TongTien, ref listView1);
            TinhTien();
        }

        public void TinhTien()
        {

            if (txtTienKDua.Text == "" || txtTienGGia.Text == "")
            {
                if (txtTienKDua.Text == "") { errorProvider1.SetError(this.txtTienKDua, ""); }
                if (txtTienGGia.Text == "") { errorProvider2.SetError(this.txtTienGGia, ""); }
            }
            txtThanhtien.Text = TongTien + "000";
            txtThanhtien.IsAccessible = false;
            int giamgia = 0;
            try
            {
                giamgia = Int32.Parse(txtTienGGia.Text);
            }
            catch { }
            int thanhtoan = TongTien * 1000 - giamgia;
            txtTienTToan.Text = thanhtoan.ToString();
            int tienkhachdua = 0;
            try
            {
                tienkhachdua = Int32.Parse(txtTienKDua.Text);
            }
            catch { }
            txtTienthua.Text = tienkhachdua - thanhtoan + "";

            LoadTrangThai();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (banttien == "" || tenkh == "") return;

            foreach (KeyValuePair<string, KhachHang> entry in FormMain.khach)
            {
                if (String.Compare(entry.Value.TenBan, banttien) == 0)
                {
                    tenkh = entry.Key;
                    //MessageBox.Show(tenkh);
                    //MessageBox.Show(TongTien.ToString());

                    string date = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                    // mdh là mã đơn hàng
                    int i = 0;

                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    string getID = @"select COUNT (dh.IDDonHang)
                                     from DonHang dh ";

                    // Tạo một đối tượng giữ lệnh cần thực thi sẽ dùng sau này xuyên xuốt cả chương trình.
                    SqlCommand cmdgetID = new SqlCommand(getID, DataProvider.cn);

                    try
                    {
                        // Mở kết nối
                        DataProvider.cn.Open();
                        i = int.Parse(cmdgetID.ExecuteScalar().ToString());
                        MessageBox.Show(i.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thực thi!");
                    }
                    finally
                    {
                        // đóng kết nối
                        DataProvider.cn.Close();
                    }
                    i++;
                    string mdh = "MDH" + i.ToString();
                    string tien = TongTien.ToString() + "000";

                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);

                    string queryInsert = @"INSERT INTO DonHang(MaDonHang, TenKhachHang, TienDonHang, ThoiGian) 
                                           VALUES ('" + mdh + "', '" + tenkh + "', '" + tien + "', '"+ date +"')";

                    // Tạo một đối tượng giữ lệnh cần thực thi sẽ dùng sau này xuyên xuốt cả chương trình.
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, DataProvider.cn);

                    try
                    {
                        // Mở kết nối
                        DataProvider.cn.Open();
                        cmdInsert.ExecuteNonQuery();

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thực thi!");
                    }
                    finally
                    {
                        // đóng kết nối
                        DataProvider.cn.Close();
                    }

                    break;
                }
            }


            FormMain.danhsach.Remove(banttien);
            FormMain.khach.Remove(tenkh);
            LoadTrangThai();

            listView1.Clear();
            txtThanhtien.Clear();
            txtTienGGia.Clear();
            txtTienKDua.Clear();
            txtTienTToan.Clear();
            txtTienthua.Clear();
        }

        int i1 = 0;
        private void TM1_Click(object sender, EventArgs e)
        {
            if (i1 == 0)
            {
                ThanhToan("TM1");
                i1++;
            }
        }

        int i2 = 0;
        private void TM2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                ThanhToan("TM2");
                i2++;
            }
        }

        int i3 = 0;
        private void TM3_Click(object sender, EventArgs e)
        {
            if (i3 == 0)
            {
                ThanhToan("TM3");
                i3++;
            }
        }

        int i4 = 0;
        private void TM4_Click(object sender, EventArgs e)
        {
            if (i4 == 0)
            {
                ThanhToan("TM4");
                i4++;
            }
        }

        int i5 = 0;
        private void TM5_Click(object sender, EventArgs e)
        {
            if (i5 == 0)
            {
                ThanhToan("TM5");
                i5++;
            }
        }


        int i6 = 0;
        private void TM6_Click(object sender, EventArgs e)
        {
            if (i6 == 0)
            {
                ThanhToan("TM6");
                i6++;
            }
        }

        int i7 = 0;
        private void TM7_Click(object sender, EventArgs e)
        {
            if (i7 == 0)
            {
                ThanhToan("TM7");
                i7++;
            }
        }

        int i8 = 0;
        private void TM8_Click(object sender, EventArgs e)
        {
            if (i8 == 0)
            {
                ThanhToan("TM8");
                i8++;
            }
        }

        int x1 = 0;
        private void TH1_Click(object sender, EventArgs e)
        {
            if (x1 == 0)
            {
                ThanhToan("TH1");
                x1++;
            }
        }

        int x2 = 0;
        private void TH2_Click(object sender, EventArgs e)
        {
            if (x2 == 0)
            {
                ThanhToan("TH2");
                x2++;
            }
        }

        int x3 = 0;
        private void TH3_Click(object sender, EventArgs e)
        {
            if (x3 == 0)
            {
                ThanhToan("TH3");
                x3++;
            }
        }

        int x4 = 0;
        private void TH4_Click(object sender, EventArgs e)
        {
            if (x4 == 0)
            {
                ThanhToan("TH4");
                x4++;
            }
        }

        int x5 = 0;
        private void TH5_Click(object sender, EventArgs e)
        {
            if (x5 == 0)
            {
                ThanhToan("TH5");
                x5++;
            }
        }

        int x6 = 0;
        private void TH6_Click(object sender, EventArgs e)
        {
            if (x6 == 0)
            {
                ThanhToan("TH6");
                x6++;
            }
        }

        int x7 = 0;
        private void TH7_Click(object sender, EventArgs e)
        {
            if (x7 == 0)
            {
                ThanhToan("TH7");
                x7++;
            }
        }

        int x8 = 0;
        private void TH8_Click(object sender, EventArgs e)
        {
            if (x8 == 0)
            {
                ThanhToan("TH8");
                x8++;
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTienKDua_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void txtTienGGia_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}
