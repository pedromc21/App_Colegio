namespace Cole.Web.Data.Entities
{
    using Microsoft.EntityFrameworkCore.Migrations;
    using Data;
    public partial class spGetStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStudents]
                    @Clave_Familia varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT c_Personas.Id, c_Personas.Apellido_Paterno, c_Personas.Apellido_Materno, c_Personas.Nombres, d_Alumnos.Matricula, d_Alumnos.Clave_Familia FROM d_Alumnos INNER JOIN c_Personas ON d_Alumnos.Persona_Id = c_Personas.Id WHERE (d_Alumnos.Clave_Familia LIKE @Clave_Familia + '%')
                END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
