using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class UserController
    {
        QuanLiThuVienHVKTQSDataContext db = null;
        public UserController()
        {
            db = new QuanLiThuVienHVKTQSDataContext();
        }
        public List<User>Detail()
        {
            var list=db.Users.ToList();
            return list;
        }
        public int IsAdmin (User user)
        {
            var s = db.Users.First(m => m.UserName == user.UserName && m.Password == user.Password);
            if(s!=null)
            {
                if (s.IsAdmin == true) return 1;
                else return 0;
            } 
            else
            {
                return -1;
            }
        }

        //Thêm user mới
        public int Add(User user)
        {
            try
            {
                var result = db.Users.First(m => m.UserName == user.UserName);
                if (result == null)
                {
                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();
                    return user.ID + 1;
                }
                else return -1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
