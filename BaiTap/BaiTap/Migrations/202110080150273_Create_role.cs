namespace BaiTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "RoleName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "RoleName");
        }
    }
}
