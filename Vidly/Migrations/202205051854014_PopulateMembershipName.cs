namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Quarterly' where Id = 3");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Annual' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
