//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace PROGRAMMING_COFFEE
//{
//    public partial class UCDangNhap : UserControl
//    {
//        public FormMain parentForm { get; set; }
//        public UCDangNhap()
//        {
//            InitializeComponent();
//        }

//        private void bunifuThinButton22_Click(object sender, EventArgs e)
//        {
//            this.parentForm.panelForm.Controls.Clear();
//            this.parentForm.panelForm.Controls.Add(new UCDangKy());
//        }

//        private void n_ButtonDangNhap_Click(object sender, EventArgs e)
//        {
//            SqlConnection conn = DBUtils.GetDBConnection();
//            conn.Open();
//            try
//            {
//                string sql = "Select VaiTro from dbo.Login where TenTK = @TK and MatKhau = @MK;";
//                SqlCommand cmd = new SqlCommand(sql, conn);
//                cmd.Parameters.Add("@TK",SqlDbType.NChar).Value = n_TextboxTenDangNhap.Text;
//                cmd.Parameters.Add("@MK", SqlDbType.NChar).Value = n_TextboxMauKhauDangNhap.Text;
//                using (SqlDataReader reader = cmd.ExecuteReader()) {
//                    if (reader.Read())
//                    {

//                        string vaitro = reader.GetString(0);
//                        string user = n_TextboxTenDangNhap.Text.Trim();
//                        FormMain.tenkhach = user;
//                        FormMain.chuadangnhap = false;
//                        FormMain.soban = FormMain.khach.ContainsKey(user)
//                                ? FormMain.khach[user].TenBan : "";
//                        if (String.Compare(vaitro.Trim(), "QuanLy") == 0)
//                        {
//                            parentForm.load_Owner();
//                        }
//                        else if (String.Compare(vaitro.Trim(), "ThuNgan") == 0)
//                        {
//                            parentForm.load_Cashier();
//                        }
//                        else if (String.Compare(vaitro.Trim(), "PhaChe") == 0)
//                        {
//                            parentForm.load_PhaChe();
//                        }
//                        else
//                        {
//                            parentForm.load_Customer();
//                        }

//                    }
//                    else {
//                        n_Status.ForeColor = Color.Red;
//                        n_Status.Text = "Tên tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại";
//                    }
//                }
//            }
//            catch
//            {
//                MessageBox.Show("Khong thanh cong");                   
//            }
//            finally
//            {
//                this.n_TextboxTenDangNhap.Text = "";
//                this.n_TextboxMauKhauDangNhap.Text = "";
//                conn.Close();
//                conn.Dispose();
//            }
//        }

//        private void n_TextboxMauKhauDangNhap_OnValueChanged(object sender, EventArgs e)
//        {
//            n_TextboxMauKhauDangNhap.isPassword = true;
//        }
//    }
//}



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
    public partial class UCDangNhap : UserControl
    {
        public FormMain parentForm { get; set; }
        public UCDangNhap()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.parentForm.panelForm.Controls.Clear();
            this.parentForm.panelForm.Controls.Add(new UCDangKy());
        }

        private void n_ButtonDangNhap_Click(object sender, EventArgs e)
        {
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            try
            {
                string sql = "Select VaiTro from dbo.Login where TenTK = @TK and MatKhau = @MK;";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                cmd.Parameters.Add("@TK", SqlDbType.NChar).Value = n_TextboxTenDangNhap.Text;
                cmd.Parameters.Add("@MK", SqlDbType.NChar).Value = n_TextboxMauKhauDangNhap.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        string vaitro = reader.GetString(0);
                        string user = n_TextboxTenDangNhap.Text.Trim();
                        FormMain.tenkhach = user;
                        FormMain.chuadangnhap = false;
                        FormMain.soban = FormMain.khach.ContainsKey(user)
                                ? FormMain.khach[user].TenBan : "";
                        if (String.Compare(vaitro.Trim(), "QuanLy") == 0)
                        {
                            parentForm.load_Owner();
                        }
                        else if (String.Compare(vaitro.Trim(), "ThuNgan") == 0)
                        {
                            parentForm.load_Cashier();
                        }
                        else if (String.Compare(vaitro.Trim(), "PhaChe") == 0)
                        {
                            parentForm.load_PhaChe();
                        }
                        else
                        {
                            parentForm.load_Customer();
                        }

                    }
                    else
                    {
                        n_Status.ForeColor = Color.Red;
                        n_Status.Text = "Tên tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Khong thanh cong");
            }
            finally
            {
                this.n_TextboxTenDangNhap.Text = "";
                this.n_TextboxMauKhauDangNhap.Text = "";
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }

        private void n_TextboxMauKhauDangNhap_OnValueChanged(object sender, EventArgs e)
        {
            n_TextboxMauKhauDangNhap.isPassword = true;
        }
    }
}

