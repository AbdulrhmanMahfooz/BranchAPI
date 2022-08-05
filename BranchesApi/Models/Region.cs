using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BranchesApi.Models
{
    public partial class Region
    {
        public Region()
        {
            Branches = new HashSet<Branch>();
            Cities = new HashSet<City>();
        }

        [Key]
        [Column("Region_No")]
        public short RegionNo { get; set; }
        [Column("Region_Name")]
        [StringLength(200)]
        public string RegionName { get; set; }
        [Column("Region_Name_Latin")]
        [StringLength(200)]
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
        [Column("Origin_Date", TypeName = "datetime")]
        public DateTime? OriginDate { get; set; }
        [Column("User_No_Update")]
        public int? UserNoUpdate { get; set; }
        [Column("Update_Date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("PC_Name")]
        [StringLength(60)]
        public string PcName { get; set; }
        [Column("PC_User_Name")]
        [StringLength(60)]
        public string PcUserName { get; set; }
        [StringLength(2)]
        public string Status { get; set; }
        [Column("Status_Date", TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }

        [ForeignKey(nameof(CountryNo))]
        [InverseProperty(nameof(Country.Regions))]
        public virtual Country CountryNoNavigation { get; set; }
        [InverseProperty(nameof(Branch.RegionNoNavigation))]
        public virtual ICollection<Branch> Branches { get; set; }
        [InverseProperty(nameof(City.RegionNoNavigation))]
        public virtual ICollection<City> Cities { get; set; }
    }
}
