namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Matricula = c.Int(nullable: false),
                        EspecialidadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicoId)
                .ForeignKey("dbo.Especialidad", t => t.EspecialidadId, cascadeDelete: true)
                .Index(t => t.EspecialidadId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        NroHistoriaClinica = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.MedicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad");
            DropForeignKey("dbo.Paciente", "MedicoId", "dbo.Medico");
            DropIndex("dbo.Paciente", new[] { "MedicoId" });
            DropIndex("dbo.Medico", new[] { "EspecialidadId" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Medico");
            DropTable("dbo.Especialidad");
        }
    }
}
