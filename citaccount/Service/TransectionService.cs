using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using citaccount.Data;
using Microsoft.EntityFrameworkCore;

namespace citaccount.Service
{
    public class TransectionService
    {
        protected readonly citaccountContext _db;
        public TransectionService(citaccountContext db)
        {
            _db = db;
        }
        //Show all transections
        public List<TblTransection> ShowAllTran()
        {
            return _db.TblTransections
                .Where(d => d.Del == true)
                .Include(d=>d.Status)
                .Include(d => d.User)
                .Include(d => d.Currency)
                .Include(d=>d.Branch)
                .OrderByDescending(d => d.Id).ToList();
        }
        public TblTransection GetTranById(int id)
        {
            TblTransection tran = _db.TblTransections.FirstOrDefault(x => x.Id == id);
            return tran;
        }
        public void CreateTran(TblTransection tran)
        {
            _db.TblTransections.Add(tran);
            _db.SaveChanges();
        }
        public void UpdateTran(TblTransection tran)
        {
            _db.TblTransections.Update(tran);
            _db.SaveChanges();
        }
        public void DeleteTran(TblTransection tran)
        {
            tran.Del = false;
            _db.TblTransections.Update(tran);
            _db.SaveChanges();
        }
        //public void ApprovedTran(TblTransection tran)
        //{
        //    tran.StatusId = 2; // 2 ແມ່ນສະຖານະ ສຳເລັດ
        //    _db.TblTransections.Update(tran);
        //    _db.SaveChanges();
        //}
        //public void RejectedTran(TblTransection tran)
        //{
        //    tran.StatusId = 3; //3 ແມ່ນສະຖານະ ຍົກເລີກ
        //    _db.TblTransections.Update(tran);
        //    _db.SaveChanges();
        //}
    }
}
