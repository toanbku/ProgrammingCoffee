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
using System.Data.Common;

namespace PROGRAMMING_COFFEE
{
    public partial class UCMenu : UserControl
    {
        //public UCThungan thungan { get; set; }
        // public FormMain parentForm { get; set; }
        



        public enum Gia { AMERICANO = 40, CAPPUCCINO = 40,CARAMEL = 45,
        BlackTea = 35,HOTBLACK = 30,MATCHA = 35,FAVOURED = 35,PEACHTEA = 30,
        GreenApple = 50,BlueberrySoda = 35,Mango = 35,BlueBerrySmoothie = 45,Mojito = 35};

        public List<DoUong> dsach = null;

        public UCMenu()
        {
            InitializeComponent();

            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            #region get
            //get thông tin từ database về form
            try
            {
                string sql = "select * from Monan where ID = @ID;";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                cmd.Parameters.Add("@ID", SqlDbType.NChar).Value = "1";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string vaitro = reader.GetString(1);
                        string vaitro1 = reader.GetString(2);
                        string vaitro2 = reader.GetString(3);
                        string vaitro3 = reader.GetString(4);// giá tiền
                        MessageBox.Show(vaitro);
                        MessageBox.Show(vaitro1);
                        MessageBox.Show(vaitro2);
                        MessageBox.Show(vaitro3);
                    }
                }
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
                DataProvider.cn = null;
            }
            catch { }
            #endregion
        }

        private void n_checkBoxAMERICANO_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxAMERICANO.Checked == true){
                this.n_nmAMERICANO.Visible = true;
            }
            else
            {
                this.n_nmAMERICANO.Visible = false;
            }
        }
        private void n_checkBoxCAPPUCCINO_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxCAPPUCCINO.Checked == true)
            {
                this.n_nmCAPPUCCINO.Visible = true;
            }
            else
            {
                this.n_nmCAPPUCCINO.Visible = false;
            }
        }
        private void n_checkBoxBlueBerrySmoothie_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxBlueBerrySmoothie.Checked == true)
            {
                this.n_nmBoxBlueBerrySmoothie.Visible = true;
            }
            else
            {
                this.n_nmBoxBlueBerrySmoothie.Visible = false;
            }
        }
        private void n_checkBoxCARAMEL_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxCARAMEL.Checked == true)
            {
                this.n_nmCARAMEL.Visible = true;
            }
            else
            {
                this.n_nmCARAMEL.Visible = false;
            }
        }
        private void n_checkBoxBlackTea_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxBlackTea.Checked == true)
            {
                this.n_nmBlackTea.Visible = true;
            }
            else
            {
                this.n_nmBlackTea.Visible = false;
            }
        }
        private void n_checkBoxHOTBLACK_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxHOTBLACK.Checked == true)
            {
                this.n_nmHOTBLACK.Visible = true;
            }
            else
            {
                this.n_nmHOTBLACK.Visible = false;
            }
        }
        private void n_checkBoxMATCHA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxMATCHA.Checked == true)
            {
                this.n_nmMATCHA.Visible = true;
            }
            else
            {
                this.n_nmMATCHA.Visible = false;
            }
        }
        private void n_checkBoxFAVOURED_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxFAVOURED.Checked == true)
            {
                this.n_nmFAVOURED.Visible = true;
            }
            else
            {
                this.n_nmFAVOURED.Visible = false;
            }
        }
        private void n_checkBoxPEACHTEA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxPEACHTEA.Checked == true)
            {
                this.n_nmPEACHTEA.Visible = true;
            }
            else
            {
                this.n_nmPEACHTEA.Visible = false;
            }
        }
        private void n_checkBoxGreenApple_CheckedChanged(object sender, EventArgs e)
        {

            if (this.n_checkBoxGreenApple.Checked == true)
            {
                this.n_nmGreenApple.Visible = true;
            }
            else
            {
                this.n_nmGreenApple.Visible = false;
            }
        }
        private void n_checkBoxBlueberrySoda_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxBlueberrySoda.Checked == true)
            {
                this.n_nmBlueberrySoda.Visible = true;
            }
            else
            {
                this.n_nmBlueberrySoda.Visible = false;
            }
        }
        private void n_checkBoxMango_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxMango.Checked == true)
            {
                this.n_nmMango.Visible = true;
            }
            else
            {
                this.n_nmMango.Visible = false;
            }
        }
        private void n_checkBoxMojito_CheckedChanged(object sender, EventArgs e)
        {
            if (this.n_checkBoxMojito.Checked == true)
            {
                this.n_nmMojito.Visible = true;
            }
            else
            {
                this.n_nmMojito.Visible = false;
            }
        }
        private void n_Call_Click(object sender, EventArgs e)
        {
            #region khoi tao ket noi ver 3.1
            // khởi tạo kết nối
            //InitializeComponent();
            //SqlConnection conn = DBUtils.GetDBConnection();
            //conn.Open();
            //string sql = "select * from Monan where ID = @ID;";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            // kết thúc khởi tạo
            #endregion
            if (String.Compare(FormMain.soban,"") == 0) { MessageBox.Show("Bạn Chưa Chọn Bàn"); return; }
            dsach = new List<DoUong>(); string tn = "Bạn Muốn Gọi : \n";
            //get thông tin từ database về form
            
            if (this.n_checkBoxAMERICANO.Checked == true) {

                //try
                //{
                //    cmd.Parameters.Add("@ID", SqlDbType.NChar).Value = "1";
                //    using (SqlDataReader reader = cmd.ExecuteReader())
                //    {
                //        if (reader.Read())
                //        {
                //            string ten1 = reader.GetString(1);
                //            string gia1 = reader.GetString(4);
                //            string soluong1 = reader.GetString(3);
                //            dsach.Add(new DoUong
                //            {
                //                Ten = ten1,
                //                giaTien = Convert.ToInt32(gia1),
                //                soLuong = Convert.ToInt32(soluong1)
                //            });
                //        }
                //    }
                //    conn.Close();
                //    conn.Dispose();
                //    conn = null;
                //}
                //catch { }
                dsach.Add(new DoUong
                {
                    Ten = "ahihi",
                    giaTien = (int)Gia.AMERICANO,
                    soLuong = (int)this.n_nmAMERICANO.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   "+dsach[dsach.Count -1].Ten + "\n");
            }
            if (this.n_checkBoxCARAMEL.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "CARAMEL MACCHIATO",
                    giaTien = (int)Gia.CARAMEL,
                    soLuong = (int)this.n_nmCARAMEL.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxCAPPUCCINO.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "CAPPUCCINO",
                    giaTien = (int)Gia.CAPPUCCINO,
                    soLuong = (int)this.n_nmCAPPUCCINO.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxBlackTea.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "BLACK TEA MACCHIATO",
                    giaTien = (int)Gia.BlackTea,
                    soLuong = (int)this.n_nmBlackTea.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxHOTBLACK.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "HOT BLACK TEA",
                    giaTien = (int)Gia.HOTBLACK,
                    soLuong = (int)this.n_nmHOTBLACK.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxMATCHA.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "MATCHA LATTE",
                    giaTien = (int)Gia.MATCHA,
                    soLuong = (int)this.n_nmMATCHA.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxFAVOURED.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "FLAVOURED TEA",
                    giaTien = (int)Gia.FAVOURED,
                    soLuong = (int)this.n_nmFAVOURED.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxPEACHTEA.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "PEACH TEA",
                    giaTien = (int)Gia.PEACHTEA,
                    soLuong = (int)this.n_nmPEACHTEA.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxGreenApple.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "GREEN APPLE",
                    giaTien = (int)Gia.GreenApple,
                    soLuong = (int)this.n_nmGreenApple.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxBlueberrySoda.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "BLUEBERRY SODA",
                    giaTien = (int)Gia.BlueberrySoda,
                    soLuong = (int)this.n_nmBlueberrySoda.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxMango.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "MANGO OGRANGE",
                    giaTien = (int)Gia.Mango,
                    soLuong = (int)this.n_nmMango.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxBlueBerrySmoothie.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "BLUEBERRY SMOOTHIE",
                    giaTien = (int)Gia.BlueBerrySmoothie,
                    soLuong = (int)this.n_nmBoxBlueBerrySmoothie.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "   " + dsach[dsach.Count - 1].Ten + "\n");
            }
            if (this.n_checkBoxMojito.Checked == true)
            {
                dsach.Add(new DoUong
                {
                    Ten = "MOJITO LEMON",
                    giaTien = (int)Gia.Mojito,
                    soLuong = (int)this.n_nmMojito.Value
                });
                tn += System.String.Concat(dsach[dsach.Count - 1].soLuong + "  " + dsach[dsach.Count - 1].Ten + "\n");
            }

            if (dsach.Count == 0) { MessageBox.Show("Bạn chưa chọn thức uống", ""); return; }
            DialogResult traloi = MessageBox.Show(tn,"Xác Nhận <OK>, Sửa đổi <Cancel>",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (traloi == DialogResult.OK) {
                FormMain.danhsach.Add(FormMain.soban,dsach);
                FormMain.khach[FormMain.tenkhach].goiMon = true;
                FormMain.chuachonmon = false;
            }
        }

        private void UCMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
