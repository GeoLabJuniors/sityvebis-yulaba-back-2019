namespace WordBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContactInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 500),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 100),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        Instagramm = c.String(),
                        AboutUs = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInfoes");
        }
    }
}
