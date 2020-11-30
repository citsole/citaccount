using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Bod { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
