namespace DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_addstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriteStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriteStatus");
        }
    }
}
