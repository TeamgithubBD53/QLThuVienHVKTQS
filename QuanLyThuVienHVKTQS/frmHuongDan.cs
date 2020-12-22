using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienHVKTQS
{
    public partial class FrmHuongDan : Form
    {
        public FrmHuongDan()
        {
            InitializeComponent();
        }

        private void GetFileAll(string tenfile)
        {
            StreamReader doc = File.OpenText(tenfile);
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
                Image img = Image.FromFile(@"hvktqs.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                //GetFileAll("GioiThieuChung.txt");
                txtGioiThieu.Text = "Trang chủ";
                Image img = Image.FromFile(@"trangchu.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtSach")
            {
                //GetFileAll("GioiThieuChung.txt");
                txtGioiThieu.Text = "Giới thiệu về sách";
                Image img = Image.FromFile(@"sach.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtNhaXuatBan")
            {
                //GetFileAll("GioiThieuChung.txt");
                txtGioiThieu.Text = "Giới thiệu về nhà xuất bản";
                Image img = Image.FromFile(@"nxb.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtNhanVien")
            {
                //GetFileAll("GioiThieuChung.txt");
                txtGioiThieu.Text = "Giới thiệu về Nhân viên";
                Image img = Image.FromFile(@"nhanvien.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTTMuon")
            {
                //GetFileAll("GioiThieuChung.txt");
                txtGioiThieu.Text = "Giới thiệu về thông tin mượn trả";
                Image img = Image.FromFile(@"ttmuon.png");
                pictureBox1.BackgroundImage = img;
            }
        }
    }
}
