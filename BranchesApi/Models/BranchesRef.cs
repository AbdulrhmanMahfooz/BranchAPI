using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BranchesApi.Models
{
    [Table("Branches_Ref")]
    public partial class BranchesRef
    {
        [Key]
        [Column("Op_No")]
        public long OpNo { get; set; }
        [Column("Branch_No")]
        public short BranchNo { get; set; }
        [Column("Branch_Name")]
        [StringLength(400)]
        public string BranchName { get; set; }
        [Column("Branch_Name_Latin")]
        [StringLength(400)]
        public string BranchNameLatin { get; set; }
        [Column("Contact_Name")]
        [StringLength(400)]
        public string ContactName { get; set; }
        [Column("Date_Open")]
        [StringLength(10)]
        public string DateOpen { get; set; }
        [Column("Country_No")]
        public short? CountryNo { get; set; }
        [Column("Region_No")]
        public short? RegionNo { get; set; }
        [Column("City_No")]
        public short? CityNo { get; set; }
        [Column("District_No")]
        public short? DistrictNo { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [Column("Street_ID")]
        [StringLength(100)]
        public string StreetId { get; set; }
        [Column("Building_ID")]
        [StringLength(100)]
        public string BuildingId { get; set; }
        [StringLength(400)]
        public string Remarks { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        [Column("Tel_1")]
        [StringLength(30)]
        public string Tel1 { get; set; }
        [StringLength(30)]
        public string Mobile { get; set; }
        [Column("Mobile_1")]
        [StringLength(30)]
        public string Mobile1 { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        [Column("Fax_1")]
        [StringLength(30)]
        public string Fax1 { get; set; }
        [Column("Zip_Code")]
        [StringLength(20)]
        public string ZipCode { get; set; }
        [Column("Po_Box")]
        [StringLength(20)]
        public string PoBox { get; set; }
        [Column("Vat_Reg")]
        [StringLength(30)]
        public string VatReg { get; set; }
        [Column("Account_No")]
        [StringLength(20)]
        public string AccountNo { get; set; }
        public bool? Stop { get; set; }
        [Column("Company_No")]
        public short? CompanyNo { get; set; }
        [Column("Archive_Seq")]
        public int? ArchiveSeq { get; set; }
        [Column("User_No_Created")]
        public int? UserNoCreated { get; set; }
        [Column("Origin_Date", TypeName = "smalldatetime")]
        public DateTime? OriginDate { get; set; }
        [Column("User_No_Update")]
        public int? UserNoUpdate { get; set; }
        [Column("Update_Date", TypeName = "smalldatetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("PC_Name")]
        [StringLength(50)]
        public string PcName { get; set; }
        [Column("PC_User_Name")]
        [StringLength(50)]
        public string PcUserName { get; set; }
        [StringLength(2)]
        public string Status { get; set; }
        [Column("Status_Date", TypeName = "smalldatetime")]
        public DateTime? StatusDate { get; set; }
    }
}
