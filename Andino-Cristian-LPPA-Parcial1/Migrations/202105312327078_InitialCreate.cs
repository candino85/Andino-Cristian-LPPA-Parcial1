namespace Andino_Cristian_LPPA_Parcial1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreApellido = c.String(),
                        Email = c.String(),
                        CUIT = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Afiliados");
        }
    }
}
