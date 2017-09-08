namespace Contrucks.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NewJobPosts", "ContractorId", "dbo.Contractors");
            DropIndex("dbo.NewJobPosts", new[] { "ContractorId" });
            AlterColumn("dbo.NewJobPosts", "ContractorId", c => c.Int());
            CreateIndex("dbo.NewJobPosts", "ContractorId");
            AddForeignKey("dbo.NewJobPosts", "ContractorId", "dbo.Contractors", "ContractorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewJobPosts", "ContractorId", "dbo.Contractors");
            DropIndex("dbo.NewJobPosts", new[] { "ContractorId" });
            AlterColumn("dbo.NewJobPosts", "ContractorId", c => c.Int(nullable: false));
            CreateIndex("dbo.NewJobPosts", "ContractorId");
            AddForeignKey("dbo.NewJobPosts", "ContractorId", "dbo.Contractors", "ContractorId", cascadeDelete: true);
        }
    }
}
