namespace QuanLyThuVienHVKTQS
{
    partial class frmNhaXuatBan
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
            this.listView_NXB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.group_NXB = new System.Windows.Forms.GroupBox();
            this.sdtnxbtxt = new System.Windows.Forms.TextBox();
            this.diachinxbtxt = new System.Windows.Forms.TextBox();
            this.tennxbtxt = new System.Windows.Forms.TextBox();
            this.manxbtxt = new System.Windows.Forms.TextBox();
            this.groupnxb_btn = new System.Windows.Forms.GroupBox();
            this.Thoat_NXB = new System.Windows.Forms.Button();
            this.Boqua_NXB = new System.Windows.Forms.Button();
            this.Luu_NXB = new System.Windows.Forms.Button();
            this.Xoa_NXB = new System.Windows.Forms.Button();
            this.Sua_NXB = new System.Windows.Forms.Button();
            this.Them_NXB = new System.Windows.Forms.Button();
            this.group_NXB.SuspendLayout();
            this.groupnxb_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_NXB
            // 
            this.listView_NXB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_NXB.FullRowSelect = true;
            this.listView_NXB.GridLines = true;
            this.listView_NXB.Location = new System.Drawing.Point(3, 1);
            this.listView_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_NXB.Name = "listView_NXB";
            this.listView_NXB.Size = new System.Drawing.Size(504, 446);
            this.listView_NXB.TabIndex = 0;
            this.listView_NXB.UseCompatibleStateImageBehavior = false;
            this.listView_NXB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã NXB";
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên NXB";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số điện thoại";
            this.columnHeader5.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // group_NXB
            // 
            this.group_NXB.Controls.Add(this.sdtnxbtxt);
            this.group_NXB.Controls.Add(this.diachinxbtxt);
            this.group_NXB.Controls.Add(this.tennxbtxt);
            this.group_NXB.Controls.Add(this.manxbtxt);
            this.group_NXB.Controls.Add(this.label1);
            this.group_NXB.Controls.Add(this.label4);
            this.group_NXB.Controls.Add(this.label2);
            this.group_NXB.Controls.Add(this.label3);
            this.group_NXB.Location = new System.Drawing.Point(508, 1);
            this.group_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_NXB.Name = "group_NXB";
            this.group_NXB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_NXB.Size = new System.Drawing.Size(412, 299);
            this.group_NXB.TabIndex = 5;
            this.group_NXB.TabStop = false;
            // 
            // sdtnxbtxt
            // 
            this.sdtnxbtxt.Location = new System.Drawing.Point(123, 174);
            this.sdtnxbtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdtnxbtxt.Name = "sdtnxbtxt";
            this.sdtnxbtxt.Size = new System.Drawing.Size(132, 22);
            this.sdtnxbtxt.TabIndex = 8;
            // 
            // diachinxbtxt
            // 
            this.diachinxbtxt.Location = new System.Drawing.Point(123, 126);
            this.diachinxbtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diachinxbtxt.Name = "diachinxbtxt";
            this.diachinxbtxt.Size = new System.Drawing.Size(132, 22);
            this.diachinxbtxt.TabIndex = 7;
            // 
            // tennxbtxt
            // 
            this.tennxbtxt.Location = new System.Drawing.Point(123, 79);
            this.tennxbtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tennxbtxt.Name = "tennxbtxt";
            this.tennxbtxt.Size = new System.Drawing.Size(132, 22);
            this.tennxbtxt.TabIndex = 6;
            // 
            // manxbtxt
            // 
            this.manxbtxt.Location = new System.Drawing.Point(123, 30);
            this.manxbtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manxbtxt.Name = "manxbtxt";
            this.manxbtxt.Size = new System.Drawing.Size(132, 22);
            this.manxbtxt.TabIndex = 5;
            // 
            // groupnxb_btn
            // 
            this.groupnxb_btn.Controls.Add(this.Thoat_NXB);
            this.groupnxb_btn.Controls.Add(this.Boqua_NXB);
            this.groupnxb_btn.Controls.Add(this.Luu_NXB);
            this.groupnxb_btn.Controls.Add(this.Xoa_NXB);
            this.groupnxb_btn.Controls.Add(this.Sua_NXB);
            this.groupnxb_btn.Controls.Add(this.Them_NXB);
            this.groupnxb_btn.Location = new System.Drawing.Point(508, 308);
            this.groupnxb_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupnxb_btn.Name = "groupnxb_btn";
            this.groupnxb_btn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupnxb_btn.Size = new System.Drawing.Size(412, 140);
            this.groupnxb_btn.TabIndex = 6;
            this.groupnxb_btn.TabStop = false;
            // 
            // Thoat_NXB
            // 
            this.Thoat_NXB.Location = new System.Drawing.Point(283, 89);
            this.Thoat_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thoat_NXB.Name = "Thoat_NXB";
            this.Thoat_NXB.Size = new System.Drawing.Size(100, 28);
            this.Thoat_NXB.TabIndex = 5;
            this.Thoat_NXB.Text = "Thoát";
            this.Thoat_NXB.UseVisualStyleBackColor = true;
            // 
            // Boqua_NXB
            // 
            this.Boqua_NXB.Location = new System.Drawing.Point(141, 89);
            this.Boqua_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Boqua_NXB.Name = "Boqua_NXB";
            this.Boqua_NXB.Size = new System.Drawing.Size(100, 28);
            this.Boqua_NXB.TabIndex = 4;
            this.Boqua_NXB.Text = "Bỏ qua";
            this.Boqua_NXB.UseVisualStyleBackColor = true;
            // 
            // Luu_NXB
            // 
            this.Luu_NXB.Location = new System.Drawing.Point(8, 89);
            this.Luu_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Luu_NXB.Name = "Luu_NXB";
            this.Luu_NXB.Size = new System.Drawing.Size(100, 28);
            this.Luu_NXB.TabIndex = 3;
            this.Luu_NXB.Text = "Lưu";
            this.Luu_NXB.UseVisualStyleBackColor = true;
            // 
            // Xoa_NXB
            // 
            this.Xoa_NXB.Location = new System.Drawing.Point(283, 23);
            this.Xoa_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Xoa_NXB.Name = "Xoa_NXB";
            this.Xoa_NXB.Size = new System.Drawing.Size(100, 28);
            this.Xoa_NXB.TabIndex = 2;
            this.Xoa_NXB.Text = "Xóa";
            this.Xoa_NXB.UseVisualStyleBackColor = true;
            this.Xoa_NXB.Click += new System.EventHandler(this.Xoa_NXB_Click);
            // 
            // Sua_NXB
            // 
            this.Sua_NXB.Location = new System.Drawing.Point(141, 23);
            this.Sua_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sua_NXB.Name = "Sua_NXB";
            this.Sua_NXB.Size = new System.Drawing.Size(100, 28);
            this.Sua_NXB.TabIndex = 1;
            this.Sua_NXB.Text = "Sửa";
            this.Sua_NXB.UseVisualStyleBackColor = true;
            this.Sua_NXB.Click += new System.EventHandler(this.Sua_NXB_Click);
            // 
            // Them_NXB
            // 
            this.Them_NXB.Location = new System.Drawing.Point(8, 23);
            this.Them_NXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Them_NXB.Name = "Them_NXB";
            this.Them_NXB.Size = new System.Drawing.Size(100, 28);
            this.Them_NXB.TabIndex = 0;
            this.Them_NXB.Text = "Thêm";
            this.Them_NXB.UseVisualStyleBackColor = true;
            this.Them_NXB.Click += new System.EventHandler(this.Them_NXB_Click);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 463);
            this.Controls.Add(this.groupnxb_btn);
            this.Controls.Add(this.group_NXB);
            this.Controls.Add(this.listView_NXB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhaXuatBan";
            this.Text = "frmNhaXuatBan";
            this.group_NXB.ResumeLayout(false);
            this.group_NXB.PerformLayout();
            this.groupnxb_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_NXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox group_NXB;
        private System.Windows.Forms.TextBox sdtnxbtxt;
        private System.Windows.Forms.TextBox diachinxbtxt;
        private System.Windows.Forms.TextBox tennxbtxt;
        private System.Windows.Forms.TextBox manxbtxt;
        private System.Windows.Forms.GroupBox groupnxb_btn;
        private System.Windows.Forms.Button Them_NXB;
        private System.Windows.Forms.Button Thoat_NXB;
        private System.Windows.Forms.Button Boqua_NXB;
        private System.Windows.Forms.Button Luu_NXB;
        private System.Windows.Forms.Button Xoa_NXB;
        private System.Windows.Forms.Button Sua_NXB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}