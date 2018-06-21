namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppoint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Pacient_id", "dbo.Pacients");
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "Pacient_id" });
            AddColumn("dbo.Appointments", "Docid", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "PacientId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "PersonTypeId_id", c => c.Int());
            CreateIndex("dbo.Appointments", "PersonTypeId_id");
            AddForeignKey("dbo.Appointments", "PersonTypeId_id", "dbo.PersonTypes", "id");
            DropColumn("dbo.Appointments", "Doctor_Id");
            DropColumn("dbo.Appointments", "Pacient_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Pacient_id", c => c.Int());
            AddColumn("dbo.Appointments", "Doctor_Id", c => c.Int());
            DropForeignKey("dbo.Appointments", "PersonTypeId_id", "dbo.PersonTypes");
            DropIndex("dbo.Appointments", new[] { "PersonTypeId_id" });
            DropColumn("dbo.Appointments", "PersonTypeId_id");
            DropColumn("dbo.Appointments", "PacientId");
            DropColumn("dbo.Appointments", "Docid");
            CreateIndex("dbo.Appointments", "Pacient_id");
            CreateIndex("dbo.Appointments", "Doctor_Id");
            AddForeignKey("dbo.Appointments", "Pacient_id", "dbo.Pacients", "id");
            AddForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors", "Id");
        }
    }
}
