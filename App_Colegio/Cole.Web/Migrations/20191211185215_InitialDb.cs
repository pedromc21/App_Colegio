using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cole.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Persona_Id = table.Column<int>(nullable: false),
                    Apellido_Paterno = table.Column<string>(maxLength: 50, nullable: true),
                    Apellido_Materno = table.Column<string>(maxLength: 50, nullable: true),
                    Nombres = table.Column<string>(maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(maxLength: 20, nullable: true),
                    Clave_Familia = table.Column<string>(maxLength: 20, nullable: true),
                    Nivel = table.Column<string>(maxLength: 20, nullable: true),
                    Grado = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
