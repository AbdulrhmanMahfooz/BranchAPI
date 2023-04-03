using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchesApi.Requestes_Responses
{
    public class addBranchRequest
    {
        public int branchId { get; set; }
        public string name { get; set; }
        public string nameEn { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string street { get; set; }
        public string building { get; set; }
        public DateTime Date_Open { get; set; }
        public int countryId { get; set; }
        public int regionId { get; set; }
        public int cityId { get; set; }
        public int districtId { get; set; }
        public string Remarks { get; set; }
        public string email { get; set; } 
        public string telephone { get; set; }
        public string telephone_2 { get; set; }
        public string mobile { get; set; }
        public string mobile_2 { get; set; }
        public string fax { get; set; }
        public string fax_2 { get; set; }
        public string zipCode { get; set; }
        public string poBox { get; set; }
        public string accountNo { get; set; }
        public string vatReg { get; set; }
        public bool stop { get; set; }

    }
}
