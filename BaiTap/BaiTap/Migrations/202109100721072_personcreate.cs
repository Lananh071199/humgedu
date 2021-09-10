namespace BaiTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(nullable: false),
                        address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
