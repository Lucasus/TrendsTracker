using System;
using System.Data.Entity.Migrations;
    
public partial class TableRename : DbMigration
{
    public override void Up()
    {
        RenameTable(name: "dbo.Keywords", newName: "Keyword");
    }
        
    public override void Down()
    {
        RenameTable(name: "dbo.Keyword", newName: "Keywords");
    }
}