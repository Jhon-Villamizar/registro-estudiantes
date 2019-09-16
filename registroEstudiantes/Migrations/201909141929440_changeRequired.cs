namespace registroEstudiantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tb_Estudiante", "direccion", c => c.String(maxLength: 255));
            AlterColumn("dbo.Tb_Estudiante", "telefono", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tb_Estudiante", "telefono", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tb_Estudiante", "direccion", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
