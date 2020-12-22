namespace QuanLyThuVienHVKTQS
{
    partial class FrmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sách");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhà xuất bản");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Người dùng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Thông tin mượn");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nhân viên");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGioiThieu = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "gtManHinhChinh";
            treeNode1.Text = "Màn hình chính";
            treeNode2.Name = "gtSach";
            treeNode2.Text = "Sách";
            treeNode3.Name = "gtNhaXuatBan";
            treeNode3.Text = "Nhà xuất bản";
            treeNode4.Name = "gtUser";
            treeNode4.Text = "Người dùng";
            treeNode5.Name = "gtTTMuon";
            treeNode5.Text = "Thông tin mượn";
            treeNode6.Name = "gtNhanVien";
            treeNode6.Text = "Nhân viên";
            treeNode7.Name = "gtPhanMem";
            treeNode7.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(193, 480);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(195, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 277);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Location = new System.Drawing.Point(195, 283);
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(813, 197);
            this.txtGioiThieu.TabIndex = 2;
            this.txtGioiThieu.Text = "";
            // 
            // FrmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 483);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmHuongDan";
            this.Text = "FrmHuongDan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtGioiThieu;
    }
}