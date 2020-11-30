using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using citaccount.Data;
using Microsoft.EntityFrameworkCore;

namespace citaccount.Service
{
    public class SettingService
    {
        protected readonly citaccountContext _db;
        public SettingService(citaccountContext db)
        {
            _db = db;
        }
        //Account
        public List<TblAcc> ShowAllAcc()
        {
            return _db.TblAccs.Where(d => d.Del == '1').OrderByDescending(d=>d.Id).ToList();
        }
        public TblAcc GetAccById(int id)
        {
            TblAcc gracc = _db.TblAccs.FirstOrDefault(x => x.Id == id);
            return gracc;
        }
        public TblAcc GetAccByAccNo(int accno)
        {
            TblAcc acc = _db.TblAccs.FirstOrDefault(x => x.AccNo == accno);
            return acc;
        }
        public void CreateAcc(TblAcc gracc)
        {
            _db.TblAccs.Add(gracc);
            _db.SaveChanges();
        }
        public void UpdateAcc(TblAcc gracc)
        {
            _db.TblAccs.Update(gracc);
            _db.SaveChanges();
        }
        public void DeleteAcc(TblAcc gracc)
        {
            gracc.Del = 0;
            _db.TblAccs.Update(gracc);
            _db.SaveChanges();
        }
        //Branch
        public List<TblBranch> ShowAllBranch()
        {
            return _db.TblBranches.Where(d => d.Del == '1').OrderBy(b=>b.Id).ToList();
        }
        public TblBranch GetBranchById(int id)
        {
            TblBranch bra = _db.TblBranches.FirstOrDefault(x => x.Id == id);
            return bra;
        }
        public void CreateBranch(TblBranch bra)
        {
            _db.TblBranches.Add(bra);
            _db.SaveChanges();
        }
        public void UpdateBranch(TblBranch bra)
        {
            _db.TblBranches.Update(bra);
            _db.SaveChanges();
        }
        public void DeleteBranch(TblBranch bra)
        {
            bra.Del = 0;
            _db.TblBranches.Update(bra);
            _db.SaveChanges();
        }
        //Currency
        public List<TblCurrency> ShowAllCurrency()
        {
            return _db.TblCurrencies.Where(d => d.Del == '1').OrderBy(b => b.Id).ToList();
        }
        public TblCurrency GetCurrencyById(int id)
        {
            TblCurrency cur = _db.TblCurrencies.FirstOrDefault(x => x.Id == id);
            return cur;
        }
        public void CreateCurrency(TblCurrency cur)
        {
            _db.TblCurrencies.Add(cur);
            _db.SaveChanges();
        }
        public void UpdateCurrency(TblCurrency cur)
        {
            _db.TblCurrencies.Update(cur);
            _db.SaveChanges();
        }
        public void DeleteCurrency(TblCurrency cur)
        {
            cur.Del = 0;
            _db.TblCurrencies.Update(cur);
            _db.SaveChanges();
        }
        //Province
        public List<TblProvince> ShowAllProvince()
        {
            return _db.TblProvinces.Where(x => x.Del == true).OrderByDescending(x => x.Id).ToList();
        }
        public TblProvince GetProvinceById(int id)
        {
            TblProvince pro = _db.TblProvinces.FirstOrDefault(x => x.Id == id);
            return pro;
        }
        public void CreatePro(TblProvince pro)
        {
            _db.TblProvinces.Add(pro);
            _db.SaveChanges();
        }
        public void UpdatePro(TblProvince pro)
        {
            _db.TblProvinces.Update(pro);
            _db.SaveChanges();
        }
        public void DeletePro(TblProvince pro)
        {
            pro.Del = false;
            _db.TblProvinces.Update(pro);
            _db.SaveChanges();
        }
        //District
        public List<TblDistrict> ShowAllDistrict()
        {
            return _db.TblDistricts
                .Where(x => x.Del == true).Include(x=>x.Pro)
                .OrderByDescending(x => x.Id).ToList();
        }
        public TblDistrict GetDistrictById(int id)
        {
            TblDistrict dis = _db.TblDistricts.FirstOrDefault(x => x.Id == id);
            return dis;
        }
        public void CreateDis(TblDistrict dis)
        {
            _db.TblDistricts.Add(dis);
            _db.SaveChanges();
        }
        public void UpdateDis(TblDistrict dis)
        {
            _db.TblDistricts.Update(dis);
            _db.SaveChanges();
        }
        public void DeleteDis(TblDistrict dis)
        {
            dis.Del = false;
            _db.TblDistricts.Update(dis);
            _db.SaveChanges();
        }
        //Village
        public List<TblVillage> ShowAllVillage()
        {
            return _db.TblVillages
                .Where(x => x.Del == true).Include(x => x.Pro).Include(x=>x.Dis)
                .OrderByDescending(x => x.Id).ToList();
        }
        public void CreateVill(TblVillage vill)
        {
            _db.TblVillages.Add(vill);
            _db.SaveChanges();
        }
        public void UpdateVill(TblVillage vill)
        {
            _db.TblVillages.Update(vill);
            _db.SaveChanges();
        }
        public void DeleteVill(TblVillage vill)
        {
            vill.Del = false;
            _db.TblVillages.Update(vill);
            _db.SaveChanges();
        }
    }
}
