namespace QuanLyThuVienHVKTQS
{
    partial class frmTTMuonSach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_MS = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.group_MS = new System.Windows.Forms.GroupBox();
            this.manvcbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.masachcbx = new System.Windows.Forms.ComboBox();
            this.sothecbx = new System.Windows.Forms.ComboBox();
            this.hantra = new System.Windows.Forms.DateTimePicker();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.soluongtxt = new System.Windows.Forms.TextBox();
            this.mamuontxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupms_btn = new System.Windows.Forms.GroupBox();
            this.Thoat_MS = new System.Windows.Forms.Button();
            this.Boqua_MS = new System.Windows.Forms.Button();
            this.Luu_MS = new System.Windows.Forms.Button();
            this.Xoa_MS = new System.Windows.Forms.Button();
            this.Sua_MS = new System.Windows.Forms.Button();
            this.Them_MS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_MStxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.group_MS.SuspendLayout();
            this.groupms_btn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_MS
            // 
            this.listView_MS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_MS.FullRowSelect = true;
            this.listView_MS.GridLines = true;
            this.listView_MS.Location = new System.Drawing.Point(2, 2);
            this.listView_MS.Name = "listView_MS";
            this.listView_MS.Size = new System.Drawing.Size(494, 440);
            this.listView_MS.TabIndex = 0;
            this.listView_MS.UseCompatibleStateImageBehavior = false;
            this.listView_MS.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 38;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã mượn";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số thẻ";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã sách";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày mượn";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hạn trả";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã nhân viên";
            this.columnHeader7.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên độc giả";
            // 
            // group_MS
            // 
            this.group_MS.Controls.Add(this.manvcbx);
            this.group_MS.Controls.Add(this.label7);
            this.group_MS.Controls.Add(this.masachcbx);
            this.group_MS.Controls.Add(this.sothecbx);
            this.group_MS.Controls.Add(this.hantra);
            this.group_MS.Controls.Add(this.ngaymuon);
            this.group_MS.Controls.Add(this.soluongtxt);
            this.group_MS.Controls.Add(this.mamuontxt);
            this.group_MS.Controls.Add(this.label6);
            this.group_MS.Controls.Add(this.label5);
            this.group_MS.Controls.Add(this.label4);
            this.group_MS.Controls.Add(this.label3);
            this.group_MS.Controls.Add(this.label2);
            this.group_MS.Controls.Add(this.label1);
            this.group_MS.Location = new System.Drawing.Point(499, 74);
            this.group_MS.Name = "group_MS";
            this.group_MS.Size = new System.Drawing.Size(340, 308);
            this.group_MS.TabIndex = 2;
            this.group_MS.TabStop = false;
            // 
            // manvcbx
            // 
            this.manvcbx.FormattingEnabled = true;
            this.manvcbx.Location = new System.Drawing.Point(124, 242);
            this.manvcbx.Name = "manvcbx";
            this.manvcbx.Size = new System.Drawing.Size(126, 21);
            this.manvcbx.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên nhân viên";
            // 
            // masachcbx
            // 
            this.masachcbx.FormattingEnabled = true;
            this.masachcbx.Location = new System.Drawing.Point(124, 85);
            this.masachcbx.Name = "masachcbx";
            this.masachcbx.Size = new System.Drawing.Size(126, 21);
            this.masachcbx.TabIndex = 14;
            // 
            // sothecbx
            // 
            this.sothecbx.FormattingEnabled = true;
            this.sothecbx.Location = new System.Drawing.Point(124, 51);
            this.sothecbx.Name = "sothecbx";
            this.sothecbx.Size = new System.Drawing.Size(126, 21);
            this.sothecbx.TabIndex = 13;
            // 
            // hantra
            // 
            this.hantra.CustomFormat = "       dd/MM/yyyy";
            this.hantra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hantra.Location = new System.Drawing.Point(124, 208);
            this.hantra.Name = "hantra";
            this.hantra.Size = new System.Drawing.Size(126, 20);
            this.hantra.TabIndex = 12;
            // 
            // ngaymuon
            // 
            this.ngaymuon.CustomFormat = "       dd/MM/yyyy";
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymuon.Location = new System.Drawing.Point(124, 169);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(126, 20);
            this.ngaymuon.TabIndex = 11;
            // 
            // soluongtxt
            // 
            this.soluongtxt.Location = new System.Drawing.Point(124, 126);
            this.soluongtxt.Name = "soluongtxt";
            this.soluongtxt.Size = new System.Drawing.Size(126, 20);
            this.soluongtxt.TabIndex = 10;
            // 
            // mamuontxt
            // 
            this.mamuontxt.Location = new System.Drawing.Point(124, 13);
            this.mamuontxt.Name = "mamuontxt";
            this.mamuontxt.Size = new System.Drawing.Size(126, 20);
            this.mamuontxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hạn trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã mượn";
            // 
            // groupms_btn
            // 
            this.groupms_btn.Controls.Add(this.Thoat_MS);
            this.groupms_btn.Controls.Add(this.Boqua_MS);
            this.groupms_btn.Controls.Add(this.Luu_MS);
            this.groupms_btn.Controls.Add(this.Xoa_MS);
            this.groupms_btn.Controls.Add(this.Sua_MS);
            this.groupms_btn.Controls.Add(this.Them_MS);
            this.groupms_btn.Location = new System.Drawing.Point(499, 388);
            this.groupms_btn.Name = "groupms_btn";
            this.groupms_btn.Size = new System.Drawing.Size(346, 54);
            this.groupms_btn.TabIndex = 3;
            this.groupms_btn.TabStop = false;
            // 
            // Thoat_MS
            // 
            this.Thoat_MS.Location = new System.Drawing.Point(288, 19);
            this.Thoat_MS.Name = "Thoat_MS";
            this.Thoat_MS.Size = new System.Drawing.Size(48, 23);
            this.Thoat_MS.TabIndex = 5;
            this.Thoat_MS.Text = "Thoát";
            this.Thoat_MS.UseVisualStyleBackColor = true;
            // 
            // Boqua_MS
            // 
            this.Boqua_MS.Location = new System.Drawing.Point(230, 19);
            this.Boqua_MS.Name = "Boqua_MS";
            this.Boqua_MS.Size = new System.Drawing.Size(52, 23);
            this.Boqua_MS.TabIndex = 4;
            this.Boqua_MS.Text = "Bỏ qua";
            this.Boqua_MS.UseVisualStyleBackColor = true;
            // 
            // Luu_MS
            // 
            this.Luu_MS.Location = new System.Drawing.Point(178, 19);
            this.Luu_MS.Name = "Luu_MS";
            this.Luu_MS.Size = new System.Drawing.Size(46, 23);
            this.Luu_MS.TabIndex = 3;
            this.Luu_MS.Text = "Lưu";
            this.Luu_MS.UseVisualStyleBackColor = true;
            // 
            // Xoa_MS
            // 
            this.Xoa_MS.Location = new System.Drawing.Point(120, 19);
            this.Xoa_MS.Name = "Xoa_MS";
            this.Xoa_MS.Size = new System.Drawing.Size(52, 23);
            this.Xoa_MS.TabIndex = 2;
            this.Xoa_MS.Text = "Xóa";
            this.Xoa_MS.UseVisualStyleBackColor = true;
            // 
            // Sua_MS
            // 
            this.Sua_MS.Location = new System.Drawing.Point(63, 19);
            this.Sua_MS.Name = "Sua_MS";
            this.Sua_MS.Size = new System.Drawing.Size(51, 23);
            this.Sua_MS.TabIndex = 1;
            this.Sua_MS.Text = "Sửa";
            this.Sua_MS.UseVisualStyleBackColor = true;
            // 
            // Them_MS
            // 
            this.Them_MS.Location = new System.Drawing.Point(11, 19);
            this.Them_MS.Name = "Them_MS";
            this.Them_MS.Size = new System.Drawing.Size(46, 23);
            this.Them_MS.TabIndex = 0;
            this.Them_MS.Text = "Thêm";
            this.Them_MS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_MStxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(499, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // search_MStxt
            // 
            this.search_MStxt.Location = new System.Drawing.Point(124, 27);
            this.search_MStxt.Name = "search_MStxt";
            this.search_MStxt.Size = new System.Drawing.Size(136, 20);
            this.search_MStxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm kiếm";
            // 
            // frmTTMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupms_btn);
            this.Controls.Add(this.group_MS);
            this.Controls.Add(this.listView_MS);
            this.Name = "frmTTMuonSach";
            this.Text = "frmTTMuonSach";
            this.group_MS.ResumeLayout(false);
            this.group_MS.PerformLayout();
            this.groupms_btn.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_MS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_MS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker hantra;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.TextBox soluongtxt;
        private System.Windows.Forms.TextBox mamuontxt;
        private System.Windows.Forms.GroupBox groupms_btn;
        private System.Windows.Forms.Button Thoat_MS;
        private System.Windows.Forms.Button Boqua_MS;
        private System.Windows.Forms.Button Luu_MS;
        private System.Windows.Forms.Button Xoa_MS;
        private System.Windows.Forms.Button Sua_MS;
        private System.Windows.Forms.Button Them_MS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox masachcbx;
        private System.Windows.Forms.ComboBox sothecbx;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox manvcbx;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_MStxt;
        private System.Windows.Forms.Label label8;
    }
}