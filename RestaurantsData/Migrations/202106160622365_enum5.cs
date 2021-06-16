namespace RestaurantsData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enum5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "CuisineType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "CuisineType");
        }
    }
}
