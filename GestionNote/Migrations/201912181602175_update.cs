namespace GestionNote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Matiere", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Matiere", c => c.String());
        }
    }
}
