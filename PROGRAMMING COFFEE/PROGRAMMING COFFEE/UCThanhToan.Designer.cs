namespace PROGRAMMING_COFFEE
{
    partial class UCThanhToan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThanhToan));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.n_Call = new Bunifu.Framework.UI.BunifuThinButton2();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 301);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(110, 30);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Tổng tiền:";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 39);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(631, 227);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Thứ Tự";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Món";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá Tiền";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 100;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 7);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(382, 30);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Danh sách các món ăn của khách hàng";
            // 
            // n_Call
            // 
            this.n_Call.ActiveBorderThickness = 1;
            this.n_Call.ActiveCornerRadius = 20;
            this.n_Call.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.n_Call.ActiveForecolor = System.Drawing.Color.White;
            this.n_Call.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.n_Call.BackColor = System.Drawing.SystemColors.Control;
            this.n_Call.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n_Call.BackgroundImage")));
            this.n_Call.ButtonText = "Gọi Tính Tiền";
            this.n_Call.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n_Call.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_Call.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.n_Call.IdleBorderThickness = 1;
            this.n_Call.IdleCornerRadius = 20;
            this.n_Call.IdleFillColor = System.Drawing.Color.White;
            this.n_Call.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.n_Call.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.n_Call.Location = new System.Drawing.Point(28, 359);
            this.n_Call.Margin = new System.Windows.Forms.Padding(5);
            this.n_Call.Name = "n_Call";
            this.n_Call.Size = new System.Drawing.Size(165, 65);
            this.n_Call.TabIndex = 149;
            this.n_Call.Tag = "";
            this.n_Call.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.n_Call.Click += new System.EventHandler(this.n_Call_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 117;
            // 
            // UCThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.n_Call);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCThanhToan";
            this.Size = new System.Drawing.Size(869, 503);
            this.Load += new System.EventHandler(this.UCThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ListView listView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 n_Call;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
