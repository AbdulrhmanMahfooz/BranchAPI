using System;
using System.Collections.Generic;

#nullable disable

namespace BranchesApi.TestModels
{
    public partial class User
    {
        public short UserNo { get; set; }
        public string UserName { get; set; }
        public string UserNameLatin { get; set; }
        public string UserLoginName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public string DateOpen { get; set; }
        public int? UserCap { get; set; }
        public bool ArabMode { get; set; }
        public bool? Post { get; set; }
        public bool? AllAccount { get; set; }
        public bool? AllCost { get; set; }
        public bool? AllActive { get; set; }
        public bool? AllProject { get; set; }
        public bool? Stop { get; set; }
        public int? UserNoCreated { get; set; }
        public DateTime? OriginDate { get; set; }
        public int? UserNoUpdate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PcName { get; set; }
        public string PcUserName { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
    }
}
