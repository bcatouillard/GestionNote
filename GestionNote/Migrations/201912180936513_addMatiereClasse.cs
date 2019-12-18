namespace GestionNote.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMatiereClasse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Classe1", c => c.String());
            AddColumn("dbo.Users", "Matiere", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Matiere");
            DropColumn("dbo.Users", "Classe1");
        }
    }
}
