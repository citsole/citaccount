using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblEmp
    {
        public TblEmp()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Bod { get; set; }
        public int? BVillId { get; set; }
        public int? BDisId { get; set; }
        public int? BProId { get; set; }
        public decimal? Phone { get; set; }
        public int? VillId { get; set; }
        public int? DisId { get; set; }
        public int? ProId { get; set; }
        public int? FamilyNo { get; set; }
        public int? PosId { get; set; }
        public int? MarId { get; set; }
        public byte[] Picture { get; set; }
        public string Note { get; set; }
        public string File { get; set; }
        public bool? Del { get; set; }

        public virtual TblDistrict BDis { get; set; }
        public virtual TblProvince BPro { get; set; }
        public virtual TblVillage BVill { get; set; }
        public virtual TblDistrict Dis { get; set; }
        public virtual TblMarry Mar { get; set; }
        public virtual TblPosition Pos { get; set; }
        public virtual TblProvince Pro { get; set; }
        public virtual TblVillage Vill { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
