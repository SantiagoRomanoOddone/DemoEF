namespace WindowsF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionEspecialidad1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Medicos", newName: "Medico");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Medico", newName: "Medicos");
        }
    }
}
