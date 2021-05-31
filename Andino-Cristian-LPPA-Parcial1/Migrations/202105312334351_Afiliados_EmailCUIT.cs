namespace Andino_Cristian_LPPA_Parcial1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Afiliados_EmailCUIT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Afiliados", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Afiliados", "CUIT", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Afiliados", "CUIT", c => c.String());
            AlterColumn("dbo.Afiliados", "Email", c => c.String());
        }
    }
}
