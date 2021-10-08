namespace BaiTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_tabe_ac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.String(nullable: false, maxLength: 10),
                        RoleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleID);
            
            AddColumn("dbo.Accounts", "RoleID", c => c.String(maxLength: 10));
            DropColumn("dbo.Accounts", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "RoleName", c => c.String(maxLength: 50));
            DropColumn("dbo.Accounts", "RoleID");
            DropTable("dbo.Roles");
        }
    }
}
