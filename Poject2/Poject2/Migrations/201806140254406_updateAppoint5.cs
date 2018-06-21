namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppoint5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "photo", c => c.String());
            AddColumn("dbo.Students", "photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "photo");
            DropColumn("dbo.Doctors", "photo");
        }
    }
}
