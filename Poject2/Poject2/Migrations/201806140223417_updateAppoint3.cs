namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppoint3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.transforPacients", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.transforPacients", "Student_id", "dbo.Students");
            DropIndex("dbo.transforPacients", new[] { "DoctorId" });
            DropIndex("dbo.transforPacients", new[] { "Student_id" });
            AddColumn("dbo.transforPacients", "DocRecId", c => c.Int(nullable: false));
            AddColumn("dbo.transforPacients", "DocsendId", c => c.Int(nullable: false));
            DropColumn("dbo.transforPacients", "DoctorId");
            DropColumn("dbo.transforPacients", "Student_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.transforPacients", "Student_id", c => c.Int());
            AddColumn("dbo.transforPacients", "DoctorId", c => c.Int(nullable: false));
            DropColumn("dbo.transforPacients", "DocsendId");
            DropColumn("dbo.transforPacients", "DocRecId");
            CreateIndex("dbo.transforPacients", "Student_id");
            CreateIndex("dbo.transforPacients", "DoctorId");
            AddForeignKey("dbo.transforPacients", "Student_id", "dbo.Students", "id");
            AddForeignKey("dbo.transforPacients", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
        }
    }
}
