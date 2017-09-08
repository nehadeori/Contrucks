namespace Contrucks.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Balances", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Balances", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Cities", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Cities", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cities", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Contractors", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Contractors", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contractors", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.JobDurations", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.JobDurations", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.NewJobPosts", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.NewJobPosts", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.NewJobPosts", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NewJobPosts", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.JobApplications", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.JobApplications", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.JobApplications", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Messages", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Messages", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Truckers", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Truckers", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Truckers", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.States", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.States", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.States", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.TruckerDetails", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.TruckerDetails", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TruckerDetails", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.TruckTypes", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.TruckTypes", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Transactions", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Transactions", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Transactions", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.LoadTypes", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.LoadTypes", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LoadTypes", "DeletedDate", c => c.DateTime());
            AlterColumn("dbo.Ratings", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Ratings", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Ratings", "DeletedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ratings", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ratings", "Deleted", c => c.String());
            AlterColumn("dbo.Ratings", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoadTypes", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoadTypes", "Deleted", c => c.String());
            AlterColumn("dbo.LoadTypes", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "Deleted", c => c.String());
            AlterColumn("dbo.Transactions", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TruckTypes", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TruckTypes", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TruckerDetails", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TruckerDetails", "Deleted", c => c.String());
            AlterColumn("dbo.TruckerDetails", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.States", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.States", "Deleted", c => c.String());
            AlterColumn("dbo.States", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Truckers", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Truckers", "Deleted", c => c.String());
            AlterColumn("dbo.Truckers", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Messages", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Messages", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobApplications", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobApplications", "Deleted", c => c.String());
            AlterColumn("dbo.JobApplications", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NewJobPosts", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NewJobPosts", "Deleted", c => c.String());
            AlterColumn("dbo.NewJobPosts", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NewJobPosts", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobDurations", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobDurations", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contractors", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contractors", "Deleted", c => c.String());
            AlterColumn("dbo.Contractors", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cities", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cities", "Deleted", c => c.String());
            AlterColumn("dbo.Cities", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Balances", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Balances", "ModifiedDate", c => c.DateTime(nullable: false));
        }
    }
}
