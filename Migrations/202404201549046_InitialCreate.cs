namespace EF_CodeFist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        KhoaId = c.Int(nullable: false, identity: true),
                        TenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.KhoaId);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        LopId = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                        KhoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LopId)
                .ForeignKey("dbo.Khoas", t => t.KhoaId, cascadeDelete: true)
                .Index(t => t.KhoaId);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false, identity: true),
                        Ten = c.String(),
                        Tuoi = c.Int(nullable: false),
                        LopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SinhVienId)
                .ForeignKey("dbo.Lops", t => t.LopId, cascadeDelete: true)
                .Index(t => t.LopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "LopId", "dbo.Lops");
            DropForeignKey("dbo.Lops", "KhoaId", "dbo.Khoas");
            DropIndex("dbo.SinhViens", new[] { "LopId" });
            DropIndex("dbo.Lops", new[] { "KhoaId" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.Lops");
            DropTable("dbo.Khoas");
        }
    }
}
