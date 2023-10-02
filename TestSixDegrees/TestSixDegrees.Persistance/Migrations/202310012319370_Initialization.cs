namespace TestSixDegrees.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuID = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Nombre = c.String(maxLength: 100),
                        Apellido = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UsuID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
