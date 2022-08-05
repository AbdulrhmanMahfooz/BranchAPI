using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BranchesApi.Models
{
    public partial class City
    {
        public City()
        {
            Branches = new HashSet<Branch>();
            Districts = new HashSet<District>();
        }

        [Key]
        [Column("City_No")]
        public short CityNo { get; set; }
        [Column("City_Name")]
        [StringLength(100)]
        public string CityName { get; set; }
        [Column("City_Name_Latin")]
        [StringLength(100)]
        public string CityNameLatin { get; set; }
        [Column("Date_Open")]
        [StringLength(10)]
        public string DateOpen { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
        [Column("Region_No")]
        public short RegionNo { get; set; }
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

        [ForeignKey(nameof(RegionNo))]
        [InverseProperty(nameof(Region.Cities))]
        public virtual Region RegionNoNavigation { get; set; }
        [InverseProperty(nameof(Branch.CityNoNavigation))]
        public virtual ICollection<Branch> Branches { get; set; }
        [InverseProperty(nameof(District.CityNoNavigation))]
        public virtual ICollection<District> Districts { get; set; }
    }
}
