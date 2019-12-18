namespace GestionNote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Classe1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Classe1", c => c.String());
        }
    }
}
