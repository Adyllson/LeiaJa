using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeiaJa.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneroEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinciaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinciaEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_AUTOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_AUTOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTelefoneEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefoneEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarioEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarioEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MunicipioEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipioEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MunicipioEntity_ProvinciaEntity_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "ProvinciaEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivroEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivroEntity_CategoriaEntity_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroEntity_TBL_AUTOR_AutoresId",
                        column: x => x.AutoresId,
                        principalTable: "TBL_AUTOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioEntity_GeneroEntity_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "GeneroEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioEntity_MunicipioEntity_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "MunicipioEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioEntity_TipoUsuarioEntity_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuarioEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmprestimoEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    LivroId = table.Column<int>(type: "int", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrega = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimoEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmprestimoEntity_LivroEntity_LivroId",
                        column: x => x.LivroId,
                        principalTable: "LivroEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprestimoEntity_UsuarioEntity_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelefoneEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoTelefoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefoneEntity_TipoTelefoneEntity_TipoTelefoneId",
                        column: x => x.TipoTelefoneId,
                        principalTable: "TipoTelefoneEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelefoneEntity_UsuarioEntity_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TBL_AUTOR",
                columns: new[] { "Id", "Nome", "SobreNome" },
                values: new object[] { 1, "Jordan", "Peterson" });

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEntity_LivroId",
                table: "EmprestimoEntity",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEntity_UsuarioId",
                table: "EmprestimoEntity",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LivroEntity_AutoresId",
                table: "LivroEntity",
                column: "AutoresId");

            migrationBuilder.CreateIndex(
                name: "IX_LivroEntity_CategoriaId",
                table: "LivroEntity",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipioEntity_ProvinciaId",
                table: "MunicipioEntity",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneEntity_TipoTelefoneId",
                table: "TelefoneEntity",
                column: "TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneEntity_UsuarioId",
                table: "TelefoneEntity",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntity_GeneroId",
                table: "UsuarioEntity",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntity_MunicipioId",
                table: "UsuarioEntity",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntity_TipoUsuarioId",
                table: "UsuarioEntity",
                column: "TipoUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprestimoEntity");

            migrationBuilder.DropTable(
                name: "TelefoneEntity");

            migrationBuilder.DropTable(
                name: "LivroEntity");

            migrationBuilder.DropTable(
                name: "TipoTelefoneEntity");

            migrationBuilder.DropTable(
                name: "UsuarioEntity");

            migrationBuilder.DropTable(
                name: "CategoriaEntity");

            migrationBuilder.DropTable(
                name: "TBL_AUTOR");

            migrationBuilder.DropTable(
                name: "GeneroEntity");

            migrationBuilder.DropTable(
                name: "MunicipioEntity");

            migrationBuilder.DropTable(
                name: "TipoUsuarioEntity");

            migrationBuilder.DropTable(
                name: "ProvinciaEntity");
        }
    }
}
