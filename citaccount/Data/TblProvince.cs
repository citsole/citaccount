using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblProvince
    {
        public TblProvince()
        {
            TblDistricts = new HashSet<TblDistrict>();
            TblEmpBPros = new HashSet<TblEmp>();
            TblEmpPros = new HashSet<TblEmp>();
            TblVillages = new HashSet<TblVillage>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? Del { get; set; }

        public virtual ICollection<TblDistrict> TblDistricts { get; set; }
        public virtual ICollection<TblEmp> TblEmpBPros { get; set; }
        public virtual ICollection<TblEmp> TblEmpPros { get; set; }
        public virtual ICollection<TblVillage> TblVillages { get; set; }
    }
}
