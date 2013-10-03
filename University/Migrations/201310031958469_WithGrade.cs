namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollment", "GradeInternal", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollment", "GradeInternal");
        }
    }
}
