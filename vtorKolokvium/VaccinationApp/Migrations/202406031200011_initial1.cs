namespace VaccinationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vaccines", "Patient_Id", c => c.Int());
            AddColumn("dbo.Vaccines", "VaccinationCenter_Id", c => c.Int());
            CreateIndex("dbo.Vaccines", "Patient_Id");
            CreateIndex("dbo.Vaccines", "VaccinationCenter_Id");
            AddForeignKey("dbo.Vaccines", "Patient_Id", "dbo.Patients", "Id");
            AddForeignKey("dbo.Vaccines", "VaccinationCenter_Id", "dbo.VaccinationCenters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vaccines", "VaccinationCenter_Id", "dbo.VaccinationCenters");
            DropForeignKey("dbo.Vaccines", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Vaccines", new[] { "VaccinationCenter_Id" });
            DropIndex("dbo.Vaccines", new[] { "Patient_Id" });
            DropColumn("dbo.Vaccines", "VaccinationCenter_Id");
            DropColumn("dbo.Vaccines", "Patient_Id");
        }
    }
}
