using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayroolAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DboEmpInfo",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpIdNo = table.Column<string>(nullable: true),
                    EmpNo = table.Column<string>(nullable: true),
                    EmpstdNo = table.Column<string>(nullable: true),
                    EmpHealthNo = table.Column<string>(nullable: true),
                    EmpStatNo = table.Column<string>(nullable: true),
                    EmpPhonNo = table.Column<string>(nullable: true),
                    EmpEmail = table.Column<string>(nullable: true),
                    EmpVoterno = table.Column<string>(nullable: true),
                    EmpSupplyCardNo = table.Column<string>(nullable: true),
                    EmpApOrNo = table.Column<string>(nullable: true),
                    EmpApOrDt = table.Column<DateTime>(nullable: true),
                    EmpBirthCou = table.Column<string>(nullable: true),
                    EmpBirthGov = table.Column<string>(nullable: true),
                    EmpMinCo = table.Column<string>(nullable: true),
                    EmpUnCo = table.Column<string>(nullable: true),
                    EmpSubUntNo = table.Column<string>(nullable: true),
                    EmpSubUntGov = table.Column<string>(nullable: true),
                    EmpFullName = table.Column<string>(nullable: true),
                    EmpFirNam = table.Column<string>(nullable: true),
                    EmpSecNam = table.Column<string>(nullable: true),
                    EmpTherNam = table.Column<string>(nullable: true),
                    EmpForthNam = table.Column<string>(nullable: true),
                    EmpAllakab = table.Column<string>(nullable: true),
                    EmpDateofbirth = table.Column<DateTime>(nullable: true),
                    EmpMomNam = table.Column<string>(nullable: true),
                    EmpFirMomNam = table.Column<string>(nullable: true),
                    EmpCecMomNam = table.Column<string>(nullable: true),
                    EmpTherMomNam = table.Column<string>(nullable: true),
                    EmpGender = table.Column<string>(nullable: true),
                    EmpSalRec = table.Column<bool>(nullable: true),
                    EmpPerTyp = table.Column<string>(nullable: true),
                    EmpPepGrp = table.Column<string>(nullable: true),
                    EmpAsgStu = table.Column<string>(nullable: true),
                    EmpNumDyMrt = table.Column<string>(nullable: true),
                    EmpDngHotPlc = table.Column<string>(nullable: true),
                    EmpMarStu = table.Column<string>(nullable: true),
                    EmpHelthInsEmp = table.Column<bool>(nullable: true),
                    EmpStaff = table.Column<bool>(nullable: true),
                    EmpStaffRes = table.Column<bool>(nullable: true),
                    EmpMedicalBen = table.Column<bool>(nullable: true),
                    EmpRadiBen = table.Column<bool>(nullable: true),
                    EmpItem = table.Column<string>(nullable: true),
                    EmpEmployer = table.Column<string>(nullable: true),
                    EmpUpgrTb = table.Column<string>(nullable: true),
                    EmpUpgrYe = table.Column<string>(nullable: true),
                    EmpEmployerTyp = table.Column<string>(nullable: true),
                    EmpAppoSt = table.Column<string>(nullable: true),
                    EmpWorSt = table.Column<string>(nullable: true),
                    EmpNati = table.Column<string>(nullable: true),
                    EmpNaDt = table.Column<DateTime>(nullable: true),
                    EmpReligion = table.Column<string>(nullable: true),
                    EmpNaNo = table.Column<string>(nullable: true),
                    EmpBocCo = table.Column<string>(nullable: true),
                    EmpLstUpdDt = table.Column<DateTime>(nullable: true),
                    EmpNatIssProv = table.Column<string>(nullable: true),
                    EmpStartDt = table.Column<DateTime>(nullable: true),
                    EmpLthServYear = table.Column<int>(nullable: true),
                    EmpLthServMonth = table.Column<int>(nullable: true),
                    EmpServAd = table.Column<string>(nullable: true),
                    EmpServAdYear = table.Column<int>(nullable: true),
                    EmpServAdMonth = table.Column<int>(nullable: true),
                    EmpServOutSalryYy = table.Column<int>(nullable: true),
                    EmpServOutSalryMm = table.Column<int>(nullable: true),
                    EmpRetNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DboEmpInfo", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DboEmpInfo");
        }
    }
}
