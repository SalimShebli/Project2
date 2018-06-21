namespace Poject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        PassWord = c.String(maxLength: 30),
                        updateAt = c.DateTime(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        section = c.String(maxLength: 20),
                        Street = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StatesId = c.Int(nullable: false),
                        Doctor_Id = c.Int(),
                        Pacient_id = c.Int(),
                        Student_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StatesId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .ForeignKey("dbo.Pacients", t => t.Pacient_id)
                .ForeignKey("dbo.Students", t => t.Student_id)
                .Index(t => t.StatesId)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Pacient_id)
                .Index(t => t.Student_id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlockPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlockId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        specializtion = c.Int(nullable: false),
                        AddressClinicId = c.Int(nullable: false),
                        personId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MapAddresses", t => t.AddressClinicId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.personId, cascadeDelete: true)
                .Index(t => t.AddressClinicId)
                .Index(t => t.personId);
            
            CreateTable(
                "dbo.MapAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Xvalue = c.Double(),
                        Yvalue = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Content = c.String(maxLength: 20),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.transforPacients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PacientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Reason = c.String(maxLength: 20),
                        DoctorId = c.Int(nullable: false),
                        Student_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_id)
                .Index(t => t.DoctorId)
                .Index(t => t.Student_id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fName = c.String(maxLength: 20),
                        lName = c.String(maxLength: 20),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        personTypeId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        RatingId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.PersonTypes", t => t.personTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.RatingId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.AddressId)
                .Index(t => t.personTypeId)
                .Index(t => t.RatingId);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        PersonFriend = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Notifacitons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 20),
                        id_sender = c.Int(nullable: false),
                        idObject = c.Int(nullable: false),
                        type = c.Int(nullable: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Content = c.String(maxLength: 20),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        value = c.Int(nullable: false),
                        Content = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        personId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.personId, cascadeDelete: true)
                .Index(t => t.personId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        YearOfStated = c.Byte(nullable: false),
                        personId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.personId, cascadeDelete: true)
                .Index(t => t.personId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 20),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.surveys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Students", "personId", "dbo.People");
            DropForeignKey("dbo.transforPacients", "Student_id", "dbo.Students");
            DropForeignKey("dbo.Subjects", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Appointments", "Student_id", "dbo.Students");
            DropForeignKey("dbo.Pacients", "personId", "dbo.People");
            DropForeignKey("dbo.Appointments", "Pacient_id", "dbo.Pacients");
            DropForeignKey("dbo.Doctors", "personId", "dbo.People");
            DropForeignKey("dbo.People", "RatingId", "dbo.Ratings");
            DropForeignKey("dbo.People", "personTypeId", "dbo.PersonTypes");
            DropForeignKey("dbo.Posts", "PersonId", "dbo.People");
            DropForeignKey("dbo.Notifacitons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Friends", "PersonId", "dbo.People");
            DropForeignKey("dbo.BlockPersons", "PersonId", "dbo.People");
            DropForeignKey("dbo.People", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.People", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.transforPacients", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Events", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "AddressClinicId", "dbo.MapAddresses");
            DropForeignKey("dbo.Appointments", "StatesId", "dbo.States");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Students", new[] { "personId" });
            DropIndex("dbo.transforPacients", new[] { "Student_id" });
            DropIndex("dbo.Subjects", new[] { "StudentId" });
            DropIndex("dbo.Appointments", new[] { "Student_id" });
            DropIndex("dbo.Pacients", new[] { "personId" });
            DropIndex("dbo.Appointments", new[] { "Pacient_id" });
            DropIndex("dbo.Doctors", new[] { "personId" });
            DropIndex("dbo.People", new[] { "RatingId" });
            DropIndex("dbo.People", new[] { "personTypeId" });
            DropIndex("dbo.Posts", new[] { "PersonId" });
            DropIndex("dbo.Notifacitons", new[] { "Person_Id" });
            DropIndex("dbo.Friends", new[] { "PersonId" });
            DropIndex("dbo.BlockPersons", new[] { "PersonId" });
            DropIndex("dbo.People", new[] { "AddressId" });
            DropIndex("dbo.People", new[] { "AccountId" });
            DropIndex("dbo.transforPacients", new[] { "DoctorId" });
            DropIndex("dbo.Events", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropIndex("dbo.Doctors", new[] { "AddressClinicId" });
            DropIndex("dbo.Appointments", new[] { "StatesId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.surveys");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Pacients");
            DropTable("dbo.Ratings");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.Posts");
            DropTable("dbo.Notifacitons");
            DropTable("dbo.Friends");
            DropTable("dbo.People");
            DropTable("dbo.transforPacients");
            DropTable("dbo.Events");
            DropTable("dbo.MapAddresses");
            DropTable("dbo.Doctors");
            DropTable("dbo.BlockPersons");
            DropTable("dbo.States");
            DropTable("dbo.Appointments");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
            DropTable("dbo.Accounts");
        }
    }
}
