using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class NhaXuatBanController
    {
        QuanLiThuVienHVKTQSDataContext db = null;
        public NhaXuatBanController()
        {
            db = new QuanLiThuVienHVKTQSDataContext();
        }
        public List<nhaxuatban> Detail()
        {
            var list = db.nhaxuatbans.ToList();
            return list;
        }
        public int Add(nhaxuatban entity)
        {
            try
            {
                db.nhaxuatbans.InsertOnSubmit(entity);
                db.SubmitChanges();
                return entity.manxb;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

    }
}
