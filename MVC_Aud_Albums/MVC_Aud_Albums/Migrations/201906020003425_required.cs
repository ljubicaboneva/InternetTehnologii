namespace MVC_Aud_Albums.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Albums", "Name", c => c.String());
        }
    }
}
