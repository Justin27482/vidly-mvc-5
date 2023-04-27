namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            
            Sql("UPDATE MembershipTypes SET DurationInMonths = 3 WHERE id = 3"); //Fixing a Data error in DB created in last Migration
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 30));
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
