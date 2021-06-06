namespace DoNhuQuynh_44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TinhThanh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenTinhThanh = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TinhThanhs");
        }
    }
}
