﻿using QuanLyThuVienHVKTQS.controller;
using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuVienHVKTQS
{
    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Load_Main();
        }
        public void Load_Main()
        {
            quanLiDanhMucToolStripMenuItem.Enabled = false;
            hienPassword.Text = "Hiện";
            passwordtxt.UseSystemPasswordChar = true;
            if (PhanQuyen.quyen==1)
            {
                quanLiDanhMucToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                danhMucĐôcGiaToolStripMenuItem.Enabled = true;
                danhMucNhânViênToolStripMenuItem.Enabled = true;
                danhMucNhaXuâtBanToolStripMenuItem.Enabled = true;
                quanLiSachToolStripMenuItem.Enabled = true;
                quảnLýMượntrảSáchToolStripMenuItem.Enabled = true;
                quanlynguoidung_toolStripMenuItem.Enabled = true;

            }
            else if(PhanQuyen.quyen==0)
            {
                quanLiDanhMucToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                danhMucĐôcGiaToolStripMenuItem.Enabled = false;
                danhMucNhânViênToolStripMenuItem.Enabled = false;
                danhMucNhaXuâtBanToolStripMenuItem.Enabled = true;
                quanLiSachToolStripMenuItem.Enabled = true;
                quảnLýMượntrảSáchToolStripMenuItem.Enabled = true;
                quanlynguoidung_toolStripMenuItem.Enabled = false;
            }
            else
            {
                đăngXuâtToolStripMenuItem.Enabled = false;
                quanLiDanhMucToolStripMenuItem.Enabled = false;
            }
        }

        //Ẩn username password khi đăng nhập thành công
        public void DN_thanhcong()
        {
            label2.Enabled = false;
            passwordtxt.Enabled = false;
            passwordtxt.Text = "";
            dangnhapbtn.Enabled = false;
            dangnhapbtn.Enabled = false;
            dangkybtn.Enabled = false;
            hienPassword.Enabled = false;

            if (PhanQuyen.quyen == 1)
            {
                this.Text = "Trang chủ Admin";
            }
            else if (PhanQuyen.quyen == 0)
            {
                this.Text = "Trang chủ User";
            }
        }

        //Đăng nhập lại
        public void DangNhanLai()
        {
            label2.Enabled = true;
            passwordtxt.Enabled = true;
            passwordtxt.Text = "";
            dangnhapbtn.Enabled = true;
            dangnhapbtn.Enabled = true;
            dangkybtn.Enabled = true;
            hienPassword.Enabled = true;
            hienPassword.Text = "Hiện";
            this.Text = "Trang chủ";
        }
        
        private void Show_NXB()
        {
            frmNhaXuatBan nxb = new frmNhaXuatBan();
            nxb.ShowDialog();
        }
        private void Show_Sach()
        {
            frmSach s = new frmSach();
            s.ShowDialog();
        }
        private void ShowDG()
        {
            frmDocGia dg = new frmDocGia();
            dg.ShowDialog();
        }
        private void Show_NV()
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }
        private void Show_MS()
        {
            frmTTMuonSach ms = new frmTTMuonSach();
            ms.ShowDialog();
        }
        private void Show_User()
        {
            frmUser user = new frmUser();
            user.ShowDialog();
        }

        private void Show_HD()
        {
            FrmHuongDan hd = new FrmHuongDan();
            hd.ShowDialog();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        //Đăng nhập
        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            var entity = new User();
            entity.UserName = usernametxt.Text;
            entity.Password = passwordtxt.Text;
            
            try
            {
                var s = new UserController();
                var result = s.IsAdmin(entity);
                if (result == -1)
                {
                    MessageBox.Show("Đăng nhập không chính xác");
                    PhanQuyen.quyen = -1;
                    Load_Main();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Đăng nhập thành công với quyền user");
                    PhanQuyen.quyen = 0;
                    Load_Main();
                    DN_thanhcong();
                }
                else if (result == 1)
                {
                    MessageBox.Show("Đăng nhập thành công với quyền admin");
                    PhanQuyen.quyen = 1;
                    Load_Main();
                    DN_thanhcong();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Đăng nhập không thành công");
                PhanQuyen.quyen = -1;
                Load_Main();

            }
            
        }



        //Thoat chương trình
        private void thoatChươngTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhMucĐôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDG();
        }

        private void danhMucNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_NV();
        }
        private void quảnLýMượntrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_MS();
        }

        private void quanlynguoidung_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_User();
        }
        private void danhMucNhaXuâtBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_NXB();
        }

        private void quanLiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Sach();
        }

        //Đăng ký
        private void dangkybtn_Click(object sender, EventArgs e)
        {
            var entity = new User();
            entity.UserName = usernametxt.Text;
            entity.Password = passwordtxt.Text;
            entity.ID = 1;
            entity.IsAdmin = false;
            var s = new UserController();
            var result = s.Add(entity);
            if (result > 0)
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else if (result == -1)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công ");
            }
        }

        //Dăng xuất
        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usernametxt.Text = "";
            passwordtxt.Text = "";
            PhanQuyen.quyen = -1;
            Load_Main();
            DangNhanLai();
        }

        private void hienPassword_Click(object sender, EventArgs e)
        {
            if(hienPassword.Text == "Hiện")
            {
                hienPassword.Text = "Ẩn";
                passwordtxt.UseSystemPasswordChar = false;
            }    
            else
            {
                hienPassword.Text = "Hiện";
                passwordtxt.UseSystemPasswordChar = true;
            }    
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_HD();
        }
    }
}
