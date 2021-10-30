namespace WindowsF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevaRelacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        IdHabitacion = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(maxLength: 12, unicode: false),
                        ClinicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdHabitacion)
                .ForeignKey("dbo.Clinica", t => t.ClinicaId, cascadeDelete: true)
                .Index(t => t.ClinicaId);
            
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Habitacion", "ClinicaId", "dbo.Clinica");
            DropIndex("dbo.Habitacion", new[] { "ClinicaId" });
            DropTable("dbo.Clinica");
            DropTable("dbo.Habitacion");
        }
    }
}
