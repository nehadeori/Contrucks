namespace Contrucks.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingNewJobPosts_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Balances",
                c => new
                    {
                        PK_BalanceId = c.Int(nullable: false, identity: true),
                        PK_UserTableId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 255),
                        ModifiedBy = c.String(maxLength: 255),
                        ModifiedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DeletedBy = c.String(maxLength: 255),
                        DeletedDate = c.DateTime(nullable: false),
                        UserTables_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PK_BalanceId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserTables_Id)
                .Index(t => t.UserTables_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        PK_CityId = c.Int(nullable: false, identity: true),
                        PK_StateId = c.Int(nullable: false),
                        CityName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_CityId)
                .ForeignKey("dbo.States", t => t.PK_StateId, cascadeDelete: true)
                .Index(t => t.PK_StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        PK_StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_StateId);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        PK_ContractorId = c.Int(nullable: false, identity: true),
                        PK_UserTableId = c.Int(nullable: false),
                        PK_StateId = c.Int(nullable: false),
                        PK_CityId = c.Int(nullable: false),
                        ContractorName = c.String(nullable: false, maxLength: 255),
                        ContractorAge = c.Int(nullable: false),
                        ContractorPhone = c.String(nullable: false, maxLength: 15),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                        UserTables_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PK_ContractorId)
                .ForeignKey("dbo.Cities", t => t.PK_CityId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.PK_StateId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserTables_Id)
                .Index(t => t.PK_StateId)
                .Index(t => t.PK_CityId)
                .Index(t => t.UserTables_Id);
            
            CreateTable(
                "dbo.JobApplications",
                c => new
                    {
                        PK_JobApplicationId = c.Int(nullable: false, identity: true),
                        PK_TruckerId = c.Int(nullable: false),
                        PK_JobId = c.Int(nullable: false),
                        CoverLetter = c.String(nullable: false, maxLength: 3000),
                        AskingPrice = c.Long(nullable: false),
                        TimeRequired = c.DateTime(nullable: false),
                        JobApplicationStatus = c.String(),
                        IsJobAwarded = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_JobApplicationId)
                .ForeignKey("dbo.NewJobPosts", t => t.PK_JobId, cascadeDelete: true)
                .ForeignKey("dbo.Truckers", t => t.PK_TruckerId, cascadeDelete: true)
                .Index(t => t.PK_TruckerId)
                .Index(t => t.PK_JobId);
            
            CreateTable(
                "dbo.NewJobPosts",
                c => new
                    {
                        PK_JobId = c.Int(nullable: false, identity: true),
                        PK_ContractorId = c.Int(nullable: false),
                        PK_LoadTypeId = c.Int(nullable: false),
                        PK_TruckTypeId = c.Int(nullable: false),
                        distance = c.Int(nullable: false),
                        JobTitle = c.String(nullable: false, maxLength: 255),
                        JobDescription = c.String(nullable: false, maxLength: 3000),
                        JobStartDate = c.DateTime(nullable: false),
                        JobEndDate = c.DateTime(),
                        EstimatedTime = c.Int(nullable: false),
                        SourceAddress = c.String(nullable: false, maxLength: 500),
                        DestinationAddress = c.String(nullable: false, maxLength: 500),
                        LoadWeight = c.Int(nullable: false),
                        Budget = c.Int(nullable: false),
                        PostedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_JobId)
                .ForeignKey("dbo.Contractors", t => t.PK_ContractorId, cascadeDelete: true)
                .ForeignKey("dbo.LoadTypes", t => t.PK_LoadTypeId, cascadeDelete: true)
                .ForeignKey("dbo.TruckTypes", t => t.PK_TruckTypeId, cascadeDelete: true)
                .Index(t => t.PK_ContractorId)
                .Index(t => t.PK_LoadTypeId)
                .Index(t => t.PK_TruckTypeId);
            
            CreateTable(
                "dbo.LoadTypes",
                c => new
                    {
                        PK_LoadTypeId = c.Int(nullable: false, identity: true),
                        LoadType = c.String(nullable: false, maxLength: 255),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_LoadTypeId);
            
            CreateTable(
                "dbo.TruckTypes",
                c => new
                    {
                        PK_TruckTypeId = c.Int(nullable: false, identity: true),
                        Trucktype = c.String(nullable: false, maxLength: 255),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_TruckTypeId);
            
            CreateTable(
                "dbo.Truckers",
                c => new
                    {
                        PK_TruckerId = c.Int(nullable: false, identity: true),
                        PK_UserTableId = c.Int(nullable: false),
                        PK_StateId = c.Int(nullable: false),
                        PK_CityId = c.Int(nullable: false),
                        TruckerName = c.String(nullable: false, maxLength: 255),
                        TruckerAge = c.Int(nullable: false),
                        TruckerLicensePlate = c.String(nullable: false, maxLength: 20),
                        TruckerPhone = c.String(nullable: false, maxLength: 15),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                        UserTable_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PK_TruckerId)
                .ForeignKey("dbo.Cities", t => t.PK_CityId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.PK_StateId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserTable_Id)
                .Index(t => t.PK_StateId)
                .Index(t => t.PK_CityId)
                .Index(t => t.UserTable_Id);
            
            CreateTable(
                "dbo.JobDurations",
                c => new
                    {
                        PK_JobDurationId = c.Int(nullable: false, identity: true),
                        PK_ContractorId = c.Int(nullable: false),
                        JobStartTime = c.DateTime(nullable: false),
                        JobStopTime = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 255),
                        ModifiedBy = c.String(maxLength: 255),
                        ModifiedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DeletedBy = c.String(maxLength: 255),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_JobDurationId)
                .ForeignKey("dbo.Contractors", t => t.PK_ContractorId, cascadeDelete: true)
                .Index(t => t.PK_ContractorId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        PK_MessageId = c.Int(nullable: false, identity: true),
                        PK_JobApplicationId = c.Int(nullable: false),
                        SenderName = c.String(nullable: false, maxLength: 255),
                        MessageSubject = c.String(maxLength: 300),
                        MessageBody = c.String(maxLength: 3000),
                        MessageDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 255),
                        ModifiedBy = c.String(maxLength: 255),
                        ModifiedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_MessageId)
                .ForeignKey("dbo.JobApplications", t => t.PK_JobApplicationId, cascadeDelete: true)
                .Index(t => t.PK_JobApplicationId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        PK_RatingId = c.Int(nullable: false, identity: true),
                        PK_ContractorId = c.Int(nullable: false),
                        PK_TruckerId = c.Int(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_RatingId)
                .ForeignKey("dbo.Contractors", t => t.PK_ContractorId, cascadeDelete: true)
                .ForeignKey("dbo.Truckers", t => t.PK_TruckerId, cascadeDelete: true)
                .Index(t => t.PK_ContractorId)
                .Index(t => t.PK_TruckerId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        PK_TransactionId = c.Int(nullable: false, identity: true),
                        PK_ContractorId = c.Int(nullable: false),
                        PK_TruckerId = c.Int(nullable: false),
                        TransactionStatus = c.String(maxLength: 15),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_TransactionId)
                .ForeignKey("dbo.Contractors", t => t.PK_ContractorId, cascadeDelete: true)
                .ForeignKey("dbo.Truckers", t => t.PK_TruckerId, cascadeDelete: true)
                .Index(t => t.PK_ContractorId)
                .Index(t => t.PK_TruckerId);
            
            CreateTable(
                "dbo.TruckerDetails",
                c => new
                    {
                        PK_TruckId = c.Int(nullable: false, identity: true),
                        PK_TruckerId = c.Int(nullable: false),
                        PK_TruckTypeId = c.Int(nullable: false),
                        TruckNumber = c.String(nullable: false, maxLength: 255),
                        TruckMileage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaximumWeightBearable = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfWheels = c.Int(nullable: false),
                        TruckBoughtIn = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Deleted = c.String(),
                        DeletedBy = c.String(),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PK_TruckId)
                .ForeignKey("dbo.Truckers", t => t.PK_TruckerId, cascadeDelete: true)
                .ForeignKey("dbo.TruckTypes", t => t.PK_TruckTypeId, cascadeDelete: true)
                .Index(t => t.PK_TruckerId)
                .Index(t => t.PK_TruckTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TruckerDetails", "PK_TruckTypeId", "dbo.TruckTypes");
            DropForeignKey("dbo.TruckerDetails", "PK_TruckerId", "dbo.Truckers");
            DropForeignKey("dbo.Transactions", "PK_TruckerId", "dbo.Truckers");
            DropForeignKey("dbo.Transactions", "PK_ContractorId", "dbo.Contractors");
            DropForeignKey("dbo.Ratings", "PK_TruckerId", "dbo.Truckers");
            DropForeignKey("dbo.Ratings", "PK_ContractorId", "dbo.Contractors");
            DropForeignKey("dbo.Messages", "PK_JobApplicationId", "dbo.JobApplications");
            DropForeignKey("dbo.JobDurations", "PK_ContractorId", "dbo.Contractors");
            DropForeignKey("dbo.JobApplications", "PK_TruckerId", "dbo.Truckers");
            DropForeignKey("dbo.Truckers", "UserTable_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Truckers", "PK_StateId", "dbo.States");
            DropForeignKey("dbo.Truckers", "PK_CityId", "dbo.Cities");
            DropForeignKey("dbo.JobApplications", "PK_JobId", "dbo.NewJobPosts");
            DropForeignKey("dbo.NewJobPosts", "PK_TruckTypeId", "dbo.TruckTypes");
            DropForeignKey("dbo.NewJobPosts", "PK_LoadTypeId", "dbo.LoadTypes");
            DropForeignKey("dbo.NewJobPosts", "PK_ContractorId", "dbo.Contractors");
            DropForeignKey("dbo.Contractors", "UserTables_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Contractors", "PK_StateId", "dbo.States");
            DropForeignKey("dbo.Contractors", "PK_CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "PK_StateId", "dbo.States");
            DropForeignKey("dbo.Balances", "UserTables_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TruckerDetails", new[] { "PK_TruckTypeId" });
            DropIndex("dbo.TruckerDetails", new[] { "PK_TruckerId" });
            DropIndex("dbo.Transactions", new[] { "PK_TruckerId" });
            DropIndex("dbo.Transactions", new[] { "PK_ContractorId" });
            DropIndex("dbo.Ratings", new[] { "PK_TruckerId" });
            DropIndex("dbo.Ratings", new[] { "PK_ContractorId" });
            DropIndex("dbo.Messages", new[] { "PK_JobApplicationId" });
            DropIndex("dbo.JobDurations", new[] { "PK_ContractorId" });
            DropIndex("dbo.Truckers", new[] { "UserTable_Id" });
            DropIndex("dbo.Truckers", new[] { "PK_CityId" });
            DropIndex("dbo.Truckers", new[] { "PK_StateId" });
            DropIndex("dbo.NewJobPosts", new[] { "PK_TruckTypeId" });
            DropIndex("dbo.NewJobPosts", new[] { "PK_LoadTypeId" });
            DropIndex("dbo.NewJobPosts", new[] { "PK_ContractorId" });
            DropIndex("dbo.JobApplications", new[] { "PK_JobId" });
            DropIndex("dbo.JobApplications", new[] { "PK_TruckerId" });
            DropIndex("dbo.Contractors", new[] { "UserTables_Id" });
            DropIndex("dbo.Contractors", new[] { "PK_CityId" });
            DropIndex("dbo.Contractors", new[] { "PK_StateId" });
            DropIndex("dbo.Cities", new[] { "PK_StateId" });
            DropIndex("dbo.Balances", new[] { "UserTables_Id" });
            DropTable("dbo.TruckerDetails");
            DropTable("dbo.Transactions");
            DropTable("dbo.Ratings");
            DropTable("dbo.Messages");
            DropTable("dbo.JobDurations");
            DropTable("dbo.Truckers");
            DropTable("dbo.TruckTypes");
            DropTable("dbo.LoadTypes");
            DropTable("dbo.NewJobPosts");
            DropTable("dbo.JobApplications");
            DropTable("dbo.Contractors");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Balances");
        }
    }
}
