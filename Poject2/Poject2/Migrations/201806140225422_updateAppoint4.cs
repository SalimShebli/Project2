namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppoint4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.transforPacients", "PacientId");
            AddForeignKey("dbo.transforPacients", "PacientId", "dbo.Pacients", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transforPacients", "PacientId", "dbo.Pacients");
            DropIndex("dbo.transforPacients", new[] { "PacientId" });
        }
    }
}
