using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intership.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql($"Insert into classTables values ('One','{DateTime.Now}','{DateTime.Now}')");
			migrationBuilder.Sql($"Insert into classTables values ('Two','{DateTime.UtcNow}','{DateTime.UtcNow}')");
			migrationBuilder.Sql($"Insert into classTables values ('Three','{DateTime.UtcNow}','{DateTime.UtcNow}')");
			migrationBuilder.Sql($"Insert into classTables values ('Four','{DateTime.UtcNow}','{DateTime.UtcNow}')");
			migrationBuilder.Sql($"Insert into classTables values ('Five','{DateTime.UtcNow}','{DateTime.UtcNow}')");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
