using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienHVKTQS.Model;
namespace QuanLyThuVienHVKTQS.controller
{
    class SachController
    {
        QuanLiThuVienHVKTQSDataContext db = null;
        public SachController()
        {
            db = new QuanLiThuVienHVKTQSDataContext();
        }
        public List<sach> Detail()
        {
            var list = db.saches.ToList();
            return list;
        }
    }
}
