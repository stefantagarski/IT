namespace lab3_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HospitalName = c.String(),
                        Address = c.String(),
                        Hospital_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hospitals", t => t.Hospital_ID)
                .Index(t => t.Hospital_ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PatientCode = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_ID = c.Int(nullable: false),
                        Doctor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_ID, t.Doctor_ID })
                .ForeignKey("dbo.Patients", t => t.Patient_ID, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_ID, cascadeDelete: true)
                .Index(t => t.Patient_ID)
                .Index(t => t.Doctor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals");
            DropForeignKey("dbo.PatientDoctors", "Doctor_ID", "dbo.Doctors");
            DropForeignKey("dbo.PatientDoctors", "Patient_ID", "dbo.Patients");
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_ID" });
            DropIndex("dbo.PatientDoctors", new[] { "Patient_ID" });
            DropIndex("dbo.Doctors", new[] { "Hospital_ID" });
            DropTable("dbo.PatientDoctors");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
