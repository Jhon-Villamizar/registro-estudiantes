namespace registroEstudiantes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrograms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tb_Estudiante", "programa", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tb_Estudiante", "programa");
        }
    }
}
