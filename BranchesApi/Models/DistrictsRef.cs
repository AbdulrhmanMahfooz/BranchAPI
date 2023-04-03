using System;
using System.Collections.Generic;

#nullable disable

namespace BranchesApi.Models
{
    public partial class DistrictsRef
    {
        public long OpNo { get; set; }
        public short DistrictNo { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameLatin { get; set; }
        public string DateOpen { get; set; }
        public string Remarks { get; set; }
        public short CountryNo { get; set; }
        public short RegionNo { get; set; }
        public short CityNo { get; set; }
        public bool? Stop { get; set; }
        public int? UserNoCreated { get; set; }
        public DateTime? OriginDate { get; set; }
        public int? UserNoUpdate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string PcName { get; set; }
        public string PcUserName { get; set; }
    }
}
