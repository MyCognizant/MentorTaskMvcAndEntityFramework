namespace EmployeeDepartmentMentorTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusinessLineAddedInDepartmentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartmentModels", "BusineesLine", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartmentModels", "BusineesLine");
        }
    }
}
