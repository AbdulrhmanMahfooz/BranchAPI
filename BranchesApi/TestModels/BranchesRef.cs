using System;
using System.Collections.Generic;

#nullable disable

namespace BranchesApi.TestModels
{
    public partial class BranchesRef
    {
        public long OpNo { get; set; }
        public short BranchNo { get; set; }
        public string BranchName { get; set; }
        public string BranchNameLatin { get; set; }
        public string ContactName { get; set; }
        public string DateOpen { get; set; }
        public short? CountryNo { get; set; }
        public short? RegionNo { get; set; }
        public short? CityNo { get; set; }
        public short? DistrictNo { get; set; }
        public string Address { get; set; }
        public string StreetId { get; set; }
        public string BuildingId { get; set; }
        public string Remarks { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Tel1 { get; set; }
        public string Mobile { get; set; }
        public string Mobile1 { get; set; }
        public string Fax { get; set; }
        public string Fax1 { get; set; }
        public string ZipCode { get; set; }
        public string PoBox { get; set; }
        public string VatReg { get; set; }
        public string AccountNo { get; set; }
        public bool? Stop { get; set; }
        public short? CompanyNo { get; set; }
        public int? ArchiveSeq { get; set; }
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
