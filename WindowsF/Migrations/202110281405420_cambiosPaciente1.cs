namespace WindowsF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosPaciente1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Paciente", "Apellido", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Paciente", "Apellido", c => c.String());
        }
    }
}
