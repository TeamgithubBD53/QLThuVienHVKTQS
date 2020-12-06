using QuanLyThuVienHVKTQS.controller;
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
    public partial class frmNhaXuatBan : Form
    {
        List<nhaxuatban> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = true;
        public frmNhaXuatBan()
        {
            InitializeComponent();
            HienThi_NXB();
        }

        private void btn_enable(bool t)
        {
            group_NXB.Enabled = t;
            Them_NXB.Enabled = !t;
            Sua_NXB.Enabled = !t;
            Xoa_NXB.Enabled = !t;
            Luu_NXB.Enabled = t;
            Boqua_NXB.Enabled = t;
            Them_bool = Sua_bool = false;
        }
        public void HienThi_NXB()
        {
            var nxb = new NhaXuatBanController();
            l = nxb.Detail();
            listView_NXB.Items.Clear();
            int i = 1;

            foreach (nhaxuatban row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.manxb.ToString());
                item.SubItems.Add(row.tennxb.ToString());
                item.SubItems.Add(row.diachi.ToString());
                item.SubItems.Add(row.sdt.ToString());
                listView_NXB.Items.Add(item);
            }
            if (PhanQuyen.quyen == 1)
                btn_enable(false);
            else
            {
                group_NXB.Enabled = false;
                Them_NXB.Enabled = Xoa_NXB.Enabled = Sua_NXB.Enabled = Luu_NXB.Enabled = Boqua_NXB.Enabled = false;
                Thoat_NXB.Enabled = true;
            }
        }

        private void Them_NXB_Click(object sender, EventArgs e)
        {

        }

        private void Sua_NXB_Click(object sender, EventArgs e)
        {

        }

        private void Xoa_NXB_Click(object sender, EventArgs e)
        {

        }
    }
}
