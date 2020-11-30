using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblTransections = new HashSet<TblTransection>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public int? EmpId { get; set; }
        public int? Del { get; set; }

        public virtual TblEmp Emp { get; set; }
        public virtual TblRole Role { get; set; }
        public virtual ICollection<TblTransection> TblTransections { get; set; }
    }
}
