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
    public partial class frmUser : Form
    {
        private bool Them_bool = false;
        private bool Sua_bool = false;
        List<User> l = null;
        public frmUser()
        {
            InitializeComponent();
            HienThi_User();
        }
        public void HienThi_User()
        {

            var user = new UserController();
            l = user.Detail();
            listView_User.Items.Clear();
            int i = 1;
            foreach (User u in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(u.ID.ToString());
                item.SubItems.Add(u.UserName.ToString());
                item.SubItems.Add(u.Password.ToString());
                item.SubItems.Add(u.IsAdmin.ToString());

                listView_User.Items.Add(item);
            }
            btn_enable(false);
        }

        public void btn_enable(bool t)
        {
            groupuser.Enabled = t;
            luu_userbtn.Enabled = t;
            boqua_userbtn.Enabled = t;
            Them_userbtn.Enabled = !t;
            Sua_userbtn.Enabled = !t;
            xoa_userbtn.Enabled = !t;
            Them_bool = Sua_bool = false;
        }

        private void listView_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_User.SelectedItems.Count == 0) return;
            int id = Convert.ToInt32(listView_User.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.ID == id);

            IDtxt.Text = l[index].ID.ToString();
            usernametxt.Text = l[index].UserName.ToString();
            passwordtxt.Text = l[index].Password.ToString();
            isadmincbx.Text = l[index].IsAdmin.ToString();
        }
    }
}
