using System;
using System.Collections.Generic;

#nullable disable

namespace BranchesApi.TestModels
{
    public partial class City
    {
        public City()
        {
            Branches = new HashSet<Branch>();
            Districts = new HashSet<District>();
        }

        public short CityNo { get; set; }
        public string CityName { get; set; }
        public string CityNameLatin { get; set; }
        public string DateOpen { get; set; }
        public string Remarks { get; set; }
        public short RegionNo { get; set; }
        public bool? Stop { get; set; }
        public int? UserNoCreated { get; set; }
        public DateTime? OriginDate { get; set; }
        public int? UserNoUpdate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string PcName { get; set; }
        public string PcUserName { get; set; }

        public virtual Region RegionNoNavigation { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
