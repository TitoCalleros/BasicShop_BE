using FluentMigrator;

namespace BasicShopAPI.Infrastructure.Migrations
{
    [Migration(20250820233010)]
    public class Migration_20250820233010_CreateProduct : Migration
    {
        private string _tableName = "Products";

        public override void Up()
        {
            Create.Table(_tableName)
                .WithColumn("Id").AsGuid().PrimaryKey().Identity()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Description").AsString(250).Nullable()
                .WithColumn("Price").AsDecimal(10, 2).NotNullable()
                .WithColumn("Stock").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedAt").AsDateTime().NotNullable()
                    .WithDefault(SystemMethods.CurrentDateTime);

            Execute.Sql($"ALTER TABLE {_tableName} ADD CONSTRAINT CK_{_tableName}_Price_Pos CHECK (Price > 0)");
            Execute.Sql($"ALTER TABLE {_tableName} ADD CONSTRAINT CK_{_tableName}_Stock_NonNegative CHECK (Stock >= 0)");

            Create.Index($"IX_{_tableName}_Name")
                .OnTable(_tableName).OnColumn("Name").Ascending();           
        }

        public override void Down()
        {
            Execute.Sql($"ALTER TABLE {_tableName} DROP CONSTRAINT CK_{_tableName}_Price_Pos");
            Execute.Sql($"ALTER TABLE {_tableName} DROP CONSTRAINT CK_{_tableName}_Stock_NonNegative");

            Delete.Table(_tableName);
        }
    }
}
