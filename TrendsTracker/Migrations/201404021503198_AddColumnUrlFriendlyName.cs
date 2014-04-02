using System;
using System.Data.Entity.Migrations;

public partial class AddColumnUrlFriendlyName : DbMigration
{
    public override void Up()
    {
        AddColumn("dbo.Keyword", "UrlFriendlyName", c => c.String());
    }
    
    public override void Down()
    {
        DropColumn("dbo.Keyword", "UrlFriendlyName");
    }
}
