//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.Common;
//using System.Data.SqlClient;

//namespace PROGRAMMING_COFFEE
//{

//    public partial class UCDangKy : UserControl
//    {
//        public bool success = false;
//        public FormMain parentForm { get; set; }
//        public UCDangKy()
//        {
//            InitializeComponent();
//        }

//        private void n_ButtonDangKi_Click(object sender, EventArgs e)
//        {
//            string pass = n_txtPass.Text, passAgain = n_txtAgain.Text;
//            //if (parentForm == null) return;
//            if (n_txtUser.Text == "" || n_txtPass.Text == "" || n_txtAgain.Text == "" || n_txtPhone.Text == "")
//            {
//                if (n_txtUser.Text == "") { errorProvider1.SetError(this.n_txtUser, "Tên tài khoản không được rỗng"); }
//                if (n_txtPass.Text == "") { errorProvider2.SetError(this.n_txtPass, "Mật khẩu không được rỗng"); }
//                if (n_txtAgain.Text == "") { errorProvider3.SetError(this.n_txtAgain, "Mật khẩu nhập lại không khớp"); }
//                if (n_txtPhone.Text == "") { errorProvider4.SetError(this.n_txtPhone, "Số điện thoại không được rỗng"); }
//            }
//            else
//            {
//                if (String.Compare(pass, passAgain) == 0)
//                {
//                    SqlConnection connection = DBUtils.GetDBConnection();
//                    connection.Open();
//                    try
//                    {
//                        // Câu lệnh Insert.
//                        string sql = "Insert into dbo.Login(TenTK, MatKhau, VaiTro) "
//                                                         + " values (@user, @pass, @role) ;";
//                        SqlCommand cmd = connection.CreateCommand();
//                        cmd.CommandText = sql;

//                        cmd.Parameters.Add("@user", SqlDbType.NChar).Value = n_txtUser.Text;
//                        cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = n_txtPass.Text;
//                        cmd.Parameters.Add("@role", SqlDbType.NChar).Value = "KhachHang";
//                        // Thực thi Command (Dùng cho delete, insert, update).
//                        int rowCount = cmd.ExecuteNonQuery();


//                        string sql2 = "Insert into dbo.KHang(TenTK, DiDong, GioiTinh) "
//                                                         + " values (@user, @phone, @sex) ;";

//                        SqlCommand cmd2 = connection.CreateCommand();
//                        cmd2.CommandText = sql2;
//                        string sex = (checkFemale.Checked == true) ? "Nu" : "Nam";

//                        cmd2.Parameters.Add("@user", SqlDbType.NChar).Value = n_txtUser.Text;
//                        cmd2.Parameters.Add("@phone", SqlDbType.NChar).Value = (string)n_txtPhone.Text;
//                        cmd2.Parameters.Add("@sex", SqlDbType.NChar).Value = sex;
//                        rowCount = cmd2.ExecuteNonQuery();
//                        //MessageBox.Show("Thanh Cong Roi");
//                        n_Status.ForeColor = Color.Green;
//                        n_Status.Text = "Đăng kí thành công";
//                        //this.parentForm.panel1
//                        MessageBox.Show("Bạn sẽ được chuyển sang trang đăng nhập");
//                        this.parentForm.panelForm.Controls.Clear();
//                        this.parentForm.panelForm.Controls.Add(new UCDangNhap());
//                    }
//                    catch
//                    {
//                        n_Status.ForeColor = Color.Red;
//                        n_Status.Text = "Tên tài khoản đã tồn tại";

//                    }
//                    finally
//                    {
//                        this.n_txtUser.Text = "";
//                        this.n_txtPhone.Text = "";
//                        connection.Close();
//                        connection.Dispose();
//                        connection = null;
//                    }
//                }
//                else {
//                    n_Status.ForeColor = Color.Red;
//                    n_Status.Text = "Mật khẩu nhập lại không khớp";
//                }
//            }
//        }

//        private void checkMale_OnChange(object sender, EventArgs e)
//        {
//            if (checkMale.Checked == true) checkFemale.Checked = false;
//            else checkFemale.Checked = true;
//        }

//        private void checkFemale_OnChange(object sender, EventArgs e)
//        {
//            if (checkFemale.Checked == true) checkMale.Checked = false;
//            else checkMale.Checked = true;
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
using System.Data.Common;
using System.Data.SqlClient;

namespace PROGRAMMING_COFFEE
{

    public partial class UCDangKy : UserControl
    {
        public bool success = false;
        public FormMain parentForm { get; set; }
        public UCDangKy()
        {
            InitializeComponent();
        }

        private void n_ButtonDangKi_Click(object sender, EventArgs e)
        {
            string pass = n_txtPass.Text, passAgain = n_txtAgain.Text;
            //if (parentForm == null) return;
            if (n_txtUser.Text == "" || n_txtPass.Text == "" || n_txtAgain.Text == "" || n_txtPhone.Text == "")
            {
                if (n_txtUser.Text == "") { errorProvider1.SetError(this.n_txtUser, "Tên tài khoản không được rỗng"); }
                if (n_txtPass.Text == "") { errorProvider2.SetError(this.n_txtPass, "Mật khẩu không được rỗng"); }
                if (n_txtAgain.Text == "") { errorProvider3.SetError(this.n_txtAgain, "Mật khẩu nhập lại không khớp"); }
                if (n_txtPhone.Text == "") { errorProvider4.SetError(this.n_txtPhone, "Số điện thoại không được rỗng"); }
            }
            else
            {
                if (String.Compare(pass, passAgain) == 0)
                {
                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    DataProvider.cn.Open();
                    try
                    {
                        // Câu lệnh Insert.
                        string sql = "Insert into dbo.Login(TenTK, MatKhau, VaiTro) "
                                                         + " values (@user, @pass, @role) ;";
                        SqlCommand cmd = DataProvider.cn.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("@user", SqlDbType.NChar).Value = n_txtUser.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = n_txtPass.Text;
                        cmd.Parameters.Add("@role", SqlDbType.NChar).Value = "KhachHang";
                        // Thực thi Command (Dùng cho delete, insert, update).
                        int rowCount = cmd.ExecuteNonQuery();


                        string sql2 = "Insert into dbo.KHang(TenTK, DiDong, GioiTinh) "
                                                         + " values (@user, @phone, @sex) ;";

                        SqlCommand cmd2 = DataProvider.cn.CreateCommand();
                        cmd2.CommandText = sql2;
                        string sex = (checkFemale.Checked == true) ? "Nu" : "Nam";

                        cmd2.Parameters.Add("@user", SqlDbType.NChar).Value = n_txtUser.Text;
                        cmd2.Parameters.Add("@phone", SqlDbType.NChar).Value = (string)n_txtPhone.Text;
                        cmd2.Parameters.Add("@sex", SqlDbType.NChar).Value = sex;
                        rowCount = cmd2.ExecuteNonQuery();
                        //MessageBox.Show("Thanh Cong Roi");
                        n_Status.ForeColor = Color.Green;
                        n_Status.Text = "Đăng kí thành công";
                        //this.parentForm.panel1
                        MessageBox.Show("Bạn sẽ được chuyển sang trang đăng nhập");
                        this.parentForm.panelForm.Controls.Clear();
                        this.parentForm.panelForm.Controls.Add(new UCDangNhap());

                    }
                    catch
                    {
                        //MessageBox.Show("Ten Dang Ky da co nguoi su dung, vui long chon ten khac");
                        n_Status.ForeColor = Color.Red;
                        n_Status.Text = "Tên tài khoản đã tồn tại";

                    }
                    finally
                    {
                        this.n_txtUser.Text = "";
                        this.n_txtPhone.Text = "";
                        DataProvider.cn.Close();
                        DataProvider.cn.Dispose();
                        DataProvider.cn = null;
                    }
                }
                else
                {
                    n_Status.ForeColor = Color.Red;
                    n_Status.Text = "Mật khẩu nhập lại không khớp";
                }
            }
        }

        private void checkMale_OnChange(object sender, EventArgs e)
        {
            if (checkMale.Checked == true) checkFemale.Checked = false;
            else checkFemale.Checked = true;
        }

        private void checkFemale_OnChange(object sender, EventArgs e)
        {
            if (checkFemale.Checked == true) checkMale.Checked = false;
            else checkMale.Checked = true;
        }
    }
}



