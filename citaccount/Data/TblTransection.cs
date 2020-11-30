using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblTransection
    {
        public int Id { get; set; }
        public string TranNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? AccDebit { get; set; }
        public int? AccCredit { get; set; }
        public string Des { get; set; }
        public decimal? Amount { get; set; }
        public int? StatusId { get; set; }
        public int? UserId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BranchId { get; set; }
        public bool? Del { get; set; }
        public int? UserApproveId { get; set; }

        public virtual TblBranch Branch { get; set; }
        public virtual TblCurrency Currency { get; set; }
        public virtual TblStatus Status { get; set; }
        public virtual TblUser User { get; set; }
    }
}
