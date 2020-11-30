using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblMarry
    {
        public TblMarry()
        {
            TblEmps = new HashSet<TblEmp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Del { get; set; }

        public virtual ICollection<TblEmp> TblEmps { get; set; }
    }
}
