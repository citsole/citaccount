using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblVillage
    {
        public TblVillage()
        {
            TblEmpBVills = new HashSet<TblEmp>();
            TblEmpVills = new HashSet<TblEmp>();
        }

        public int Id { get; set; }
        public int? DisId { get; set; }
        public int? ProId { get; set; }
        public string Name { get; set; }
        public bool? Del { get; set; }

        public virtual TblDistrict Dis { get; set; }
        public virtual TblProvince Pro { get; set; }
        public virtual ICollection<TblEmp> TblEmpBVills { get; set; }
        public virtual ICollection<TblEmp> TblEmpVills { get; set; }
    }
}
