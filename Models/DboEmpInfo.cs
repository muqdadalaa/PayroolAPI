using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayroolAPI.Models
{
    public partial class DboEmpInfo
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpIdNo { get; set; }
        public string EmpNo { get; set; }
        public string EmpstdNo { get; set; }
        public string EmpHealthNo { get; set; }
        public string EmpStatNo { get; set; }
        public string EmpPhonNo { get; set; }
        public string EmpEmail { get; set; }
        public string EmpVoterno { get; set; }
        public string EmpSupplyCardNo { get; set; }
        public string EmpApOrNo { get; set; }
        public DateTime? EmpApOrDt { get; set; }
        public string EmpBirthCou { get; set; }
        public string EmpBirthGov { get; set; }
        public string EmpMinCo { get; set; }
        public string EmpUnCo { get; set; }
        public string EmpSubUntNo { get; set; }
        public string EmpSubUntGov { get; set; }
        public string EmpFullName { get; set; }
        public string EmpFirNam { get; set; }
        public string EmpSecNam { get; set; }
        public string EmpTherNam { get; set; }
        public string EmpForthNam { get; set; }
        public string EmpAllakab { get; set; }
        public DateTime? EmpDateofbirth { get; set; }
        public string EmpMomNam { get; set; }
        public string EmpFirMomNam { get; set; }
        public string EmpCecMomNam { get; set; }
        public string EmpTherMomNam { get; set; }
        public string EmpGender { get; set; }
        public bool? EmpSalRec { get; set; }
        public string EmpPerTyp { get; set; }
        public string EmpPepGrp { get; set; }
        public string EmpAsgStu { get; set; }
        public string EmpNumDyMrt { get; set; }
        public string EmpDngHotPlc { get; set; }
        public string EmpMarStu { get; set; }
        public bool? EmpHelthInsEmp { get; set; }
        public bool? EmpStaff { get; set; }
        public bool? EmpStaffRes { get; set; }
        public bool? EmpMedicalBen { get; set; }
        public bool? EmpRadiBen { get; set; }
        public string EmpItem { get; set; }
        public string EmpEmployer { get; set; }
        public string EmpUpgrTb { get; set; }
        public string EmpUpgrYe { get; set; }
        public string EmpEmployerTyp { get; set; }
        public string EmpAppoSt { get; set; }
        public string EmpWorSt { get; set; }
        public string EmpNati { get; set; }
        public DateTime? EmpNaDt { get; set; }
        public string EmpReligion { get; set; }
        public string EmpNaNo { get; set; }
        public string EmpBocCo { get; set; }
        public DateTime? EmpLstUpdDt { get; set; }
        public string EmpNatIssProv { get; set; }
        public DateTime? EmpStartDt { get; set; }
        public int? EmpLthServYear { get; set; }
        public int? EmpLthServMonth { get; set; }
        public string EmpServAd { get; set; }
        public int? EmpServAdYear { get; set; }
        public int? EmpServAdMonth { get; set; }
        public int? EmpServOutSalryYy { get; set; }
        public int? EmpServOutSalryMm { get; set; }
        public string EmpRetNo { get; set; }
    }
}
