using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BranchesApi.Models
{
    [Table("Regions_Ref")]
    public partial class RegionsRef
    {
        [Key]
        [Column("Op_No")]
        public long OpNo { get; set; }
        [Column("Region_No")]
        public short RegionNo { get; set; }
        [Column("Region_Name")]
        [StringLength(400)]
        public string RegionName { get; set; }
        [Column("Region_Name_Latin")]
        [StringLength(400)]
        public string RegionNameLatin { get; set; }
        [Column("Date_Open")]
        [StringLength(10)]
        public string DateOpen { get; set; }
        [Column("Country_No")]
        public short CountryNo { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
        public bool? Stop { get; set; }
        [Column("User_No_Created")]
        public int? UserNoCreated { get; set; }
        [Column("Origin_Date", TypeName = "smalldatetime")]
        public DateTime? OriginDate { get; set; }
        [Column("User_No_Update")]
        public int? UserNoUpdate { get; set; }
        [Column("Update_Date", TypeName = "smalldatetime")]
        public DateTime? UpdateDate { get; set; }
        [StringLength(2)]
        public string Status { get; set; }
        [Column("Status_Date", TypeName = "smalldatetime")]
        public DateTime? StatusDate { get; set; }
        [Column("PC_Name")]
        [StringLength(50)]
        public string PcName { get; set; }
        [Column("PC_User_Name")]
        [StringLength(50)]
        public string PcUserName { get; set; }
    }
}
