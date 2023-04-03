using BranchesApi.Models;
using BranchesApi.Requestes_Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly TestContext _testContext;
        public BranchController(TestContext testContext)
        {
            _testContext = testContext;
        }
        [HttpPost("get_branche")]
        public async Task<IActionResult> getBranches(getBranchRequest getBranch)
        {
            var test = await _testContext.Countries.Where(x => x.CountryNo == 1).Select(x => new { x.CountryName, x.CountryNameLatin }).ToListAsync();
            var branch = await _testContext.Branches
            .Where(x => x.BranchNo == getBranch.branchId)
            .FirstOrDefaultAsync();
            var testc = new addBranchResponse
            {
                building = branch.BuildingId,
                email = branch.Email,
                stop = branch.Stop,
                street = branch.StreetId,
                accountNo = branch.AccountNo,
                address = branch.Address,
                cityId = (short)branch.CityNo,
                contact = branch.ContactName,
                countryId = (short)branch.CountryNo,
                Date_Open = branch.DateOpen,
                districtId = (short)branch.DistrictNo,
                fax = branch.Fax,
                fax_2 = branch.Fax1,
                telephone = branch.Tel,
                telephone_2 = branch.Tel1,
                mobile = branch.Mobile,
                mobile_2 = branch.Mobile1,
                name = branch.BranchName,
                nameEn = branch.BranchNameLatin,
                poBox = branch.PoBox,
                zipCode = branch.ZipCode,
                regionId = (short)branch.RegionNo,
                Remarks = branch.Remarks,
                vatReg = branch.VatReg
            };
            //.Select(x => new addBranchResponse
            //{
            //    building=x.BuildingId,
            //    email=x.Email,
            //    stop=x.Stop,
            //    street=x.StreetId,
            //    accountNo=x.AccountNo,
            //    address=x.Address,
            //    cityId=(short)x.CityNo,
            //    contact=x.ContactName,
            //    countryId=(short)x.CountryNo,
            //    Date_Open=x.DateOpen,
            //    districtId=(short)x.DistrictNo,
            //    fax=x.Fax,
            //    fax_2=x.Fax1,
            //    telephone=x.Tel,
            //    telephone_2=x.Tel1,
            //    mobile=x.Mobile,
            //    mobile_2=x.Mobile1,
            //    name=x.BranchName,
            //    nameEn=x.BranchNameLatin,
            //    poBox=x.PoBox,
            //    zipCode=x.ZipCode,
            //    regionId=(short)x.RegionNo,
            //    Remarks=x.Remarks,
            //    vatReg=x.VatReg
            //}).FirstOrDefaultAsync();
            return Ok();
        }
        [HttpPost("add_branch")]
        public async Task<IActionResult> addBranch(addBranchRequest add)
        {
            if(add.branchId==0)
            {
                var addBranch = new Models.Branch
                {
                    BranchName = add.name,
                    BranchNameLatin = add.nameEn,
                    Address = add.address,
                    ContactName = add.contact,
                    DateOpen = add.Date_Open,
                    CountryNo = (short)add.countryId,
                    RegionNo = (short)add.regionId,
                    CityNo = (short)add.cityId,
                    DistrictNo = (short)add.districtId,
                    StreetId = add.street,
                    BuildingId = add.building,
                    Remarks = add.Remarks,
                    Email = add.email,
                    Tel = add.telephone,
                    Tel1 = add.telephone_2,
                    Mobile = add.mobile,
                    Mobile1 = add.mobile_2,
                    Fax = add.fax,
                    Fax1 = add.fax_2,
                    ZipCode = add.zipCode,
                    PoBox = add.poBox,
                    AccountNo = add.accountNo,
                    VatReg = add.vatReg,
                    Stop = add.stop
                };
                await _testContext.Branches.AddAsync(addBranch);
                await _testContext.SaveChangesAsync();
                return Ok(addBranch);
            }
            else
            {
                var branch = await _testContext.Branches
                    .Where(x => x.BranchNo == add.branchId)
                    .FirstOrDefaultAsync();
                    branch.BranchName = add.name;
                    branch.BranchNameLatin = add.nameEn;
                    branch.Address = add.address;
                    branch.ContactName = add.contact;
                    branch.DateOpen = add.Date_Open;
                    branch.CountryNo = (short)add.countryId;
                    branch.RegionNo = (short)add.regionId;
                    branch.CityNo = (short)add.cityId;
                    branch.DistrictNo = (short)add.districtId;
                    branch.StreetId = add.street;
                    branch.BuildingId = add.building;
                    branch.Remarks = add.Remarks;
                    branch.Email = add.email;
                    branch.Tel = add.telephone;
                    branch.Tel1 = add.telephone_2;
                    branch.Mobile = add.mobile;
                    branch.Mobile1 = add.mobile_2;
                    branch.Fax = add.fax;
                    branch.Fax1 = add.fax_2;
                    branch.ZipCode = add.zipCode;
                    branch.PoBox = add.poBox;
                    branch.AccountNo = add.accountNo;
                    branch.VatReg = add.vatReg;
                    branch.Stop = add.stop;
                await _testContext.SaveChangesAsync();
                return Ok(branch);
            }
           
        }
    }
}
