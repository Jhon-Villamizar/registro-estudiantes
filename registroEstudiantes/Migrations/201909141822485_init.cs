namespace registroEstudiantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_Estudiante",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(nullable: false, maxLength: 255),
                        apellidos = c.String(nullable: false, maxLength: 255),
                        tipoEstudiante = c.String(nullable: false, maxLength: 255),
                        correo = c.String(nullable: false, maxLength: 255),
                        direccion = c.String(nullable: false, maxLength: 255),
                        telefono = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tb_Estudiante");
        }
    }
}
