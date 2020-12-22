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
            StreamReader doc = File.OpenText("../../../Resource/" + tenfile);
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }


        private void GetImgAll(string tenimg)
        {
            Image img = Image.FromFile("../../../Resource/" + @tenimg);
            pictureBox1.BackgroundImage = img;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"hvktqs.jpg");
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"trangchu.png");
            }
            else if (e.Node.Name == "gtSach")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"sach.png");
            }
            else if (e.Node.Name == "gtNhaXuatBan")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"nxb.png");
            }
            else if (e.Node.Name == "gtNhanVien")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"nhanvien.png");
            }
            else if (e.Node.Name == "gtTTMuon")
            {
                GetFileAll("GioiThieuChung.txt");
                GetImgAll(@"ttmuon.png");
            }
        }
    }
}
