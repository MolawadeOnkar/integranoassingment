namespace AssingmentEx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        AdminUserId = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        EmailId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminUsers");
        }
    }
}
