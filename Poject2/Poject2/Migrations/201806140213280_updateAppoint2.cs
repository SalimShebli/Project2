namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppoint2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Student_id", "dbo.Students");
            DropIndex("dbo.Appointments", new[] { "Student_id" });
            CreateIndex("dbo.Appointments", "PacientId");
            AddForeignKey("dbo.Appointments", "PacientId", "dbo.Pacients", "id", cascadeDelete: true);
            DropColumn("dbo.Appointments", "Student_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Student_id", c => c.Int());
            DropForeignKey("dbo.Appointments", "PacientId", "dbo.Pacients");
            DropIndex("dbo.Appointments", new[] { "PacientId" });
            CreateIndex("dbo.Appointments", "Student_id");
            AddForeignKey("dbo.Appointments", "Student_id", "dbo.Students", "id");
        }
    }
}
