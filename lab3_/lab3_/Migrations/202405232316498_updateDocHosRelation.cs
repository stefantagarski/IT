namespace lab3_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDocHosRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_ID" });
            RenameColumn(table: "dbo.Doctors", name: "Hospital_ID", newName: "hospitalID");
            AlterColumn("dbo.Doctors", "hospitalID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "hospitalID");
            AddForeignKey("dbo.Doctors", "hospitalID", "dbo.Hospitals", "ID", cascadeDelete: true);
            DropColumn("dbo.Doctors", "HospitalName");
            DropColumn("dbo.Doctors", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Address", c => c.String());
            AddColumn("dbo.Doctors", "HospitalName", c => c.String());
            DropForeignKey("dbo.Doctors", "hospitalID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "hospitalID" });
            AlterColumn("dbo.Doctors", "hospitalID", c => c.Int());
            RenameColumn(table: "dbo.Doctors", name: "hospitalID", newName: "Hospital_ID");
            CreateIndex("dbo.Doctors", "Hospital_ID");
            AddForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals", "ID");
        }
    }
}
