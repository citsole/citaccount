using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblDistrict
    {
        public TblDistrict()
        {
            TblEmpBDis = new HashSet<TblEmp>();
            TblEmpDis = new HashSet<TblEmp>();
            TblVillages = new HashSet<TblVillage>();
        }

        public int Id { get; set; }
        public int? ProId { get; set; }
        public string Name { get; set; }
        public bool? Del { get; set; }

        public virtual TblProvince Pro { get; set; }
        public virtual ICollection<TblEmp> TblEmpBDis { get; set; }
        public virtual ICollection<TblEmp> TblEmpDis { get; set; }
        public virtual ICollection<TblVillage> TblVillages { get; set; }
    }
}
