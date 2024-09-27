namespace VaccinationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial51 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "VaccinationCenter_Id", c => c.Int());
            CreateIndex("dbo.Patients", "VaccinationCenter_Id");
            AddForeignKey("dbo.Patients", "VaccinationCenter_Id", "dbo.VaccinationCenters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "VaccinationCenter_Id", "dbo.VaccinationCenters");
            DropIndex("dbo.Patients", new[] { "VaccinationCenter_Id" });
            DropColumn("dbo.Patients", "VaccinationCenter_Id");
        }
    }
}
