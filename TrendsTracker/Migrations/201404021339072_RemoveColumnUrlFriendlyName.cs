using System;
using System.Data.Entity.Migrations;

public partial class RemoveColumnUrlFriendlyName : DbMigration
{
    public override void Up()
    {
        DropColumn("dbo.Keyword", "UrlFriendlyName");
    }
    
    public override void Down()
    {
        AddColumn("dbo.Keyword", "UrlFriendlyName", c => c.String());
    }
}
