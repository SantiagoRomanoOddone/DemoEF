namespace WindowsF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionEspecialidad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        EspecialidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.EspecialidadId);
            
            AddColumn("dbo.Medicos", "EspecialidadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicos", "EspecialidadId");
            AddForeignKey("dbo.Medicos", "EspecialidadId", "dbo.Especialidad", "EspecialidadId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicos", "EspecialidadId", "dbo.Especialidad");
            DropIndex("dbo.Medicos", new[] { "EspecialidadId" });
            DropColumn("dbo.Medicos", "EspecialidadId");
            DropTable("dbo.Especialidad");
        }
    }
}
