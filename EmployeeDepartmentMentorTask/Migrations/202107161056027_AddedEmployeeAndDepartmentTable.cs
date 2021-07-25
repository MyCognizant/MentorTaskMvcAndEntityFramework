namespace EmployeeDepartmentMentorTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployeeAndDepartmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentModels",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Designation = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.DepartmentModels", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeModels", "DepartmentId", "dbo.DepartmentModels");
            DropIndex("dbo.EmployeeModels", new[] { "DepartmentId" });
            DropTable("dbo.EmployeeModels");
            DropTable("dbo.DepartmentModels");
        }
    }
}
