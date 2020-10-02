using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationOIFUS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Asunto = table.Column<string>(nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NumeroIdentificacion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iso = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PrintableName = table.Column<string>(nullable: true),
                    Iso3 = table.Column<string>(nullable: true),
                    NumCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaNotificaciones = table.Column<DateTime>(nullable: true),
                    Notificacion = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblDiscapacidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDiscapacidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblEstratoSocioEconomico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEstratoSocioEconomico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblEtnia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEtnia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblGenero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGenero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblIdentidaDeGenero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblIdentidaDeGenero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblJornadaDeTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblJornadaDeTrabajo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblLocalidadTrabaja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLocalidadTrabaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblLocalidadVive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLocalidadVive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblNivelDeEscolaridad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblNivelDeEscolaridad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblOrientacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrientacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblSeguridadSocial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSeguridadSocial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblSubsidio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSubsidio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTipoDeVivienda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTipoDeVivienda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTipoDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTipoDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Usuario = table.Column<string>(nullable: true),
                    Pasword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroDocumento = table.Column<long>(nullable: true),
                    IdTipoDocumento = table.Column<int>(nullable: true),
                    IdGenero = table.Column<int>(nullable: true),
                    IdOrientacionSexual = table.Column<int>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    IdIdentidadGenero = table.Column<int>(nullable: true),
                    Edad = table.Column<int>(nullable: true),
                    IdEtnia = table.Column<int>(nullable: true),
                    Telefono = table.Column<int>(nullable: true),
                    IdLocalidad = table.Column<int>(nullable: true),
                    EsVictimaConflictoA = table.Column<bool>(nullable: true),
                    EsDiscapacitado = table.Column<bool>(nullable: true),
                    IdTipoDiscapacidad = table.Column<int>(nullable: true),
                    IdTipoVivienda = table.Column<int>(nullable: true),
                    IdSeguridadSocial = table.Column<int>(nullable: true),
                    IdNivielEscolaridad = table.Column<int>(nullable: true),
                    EsJefeHogar = table.Column<bool>(nullable: true),
                    IdEstratiSocioEconomico = table.Column<int>(nullable: true),
                    IdLocalidadTrabajo = table.Column<int>(nullable: true),
                    IdJornadaTrabajo = table.Column<int>(nullable: true),
                    IdSubsidios = table.Column<int>(nullable: true),
                    IdUsuario = table.Column<int>(nullable: true),
                    TblDiscapacidadId = table.Column<int>(nullable: true),
                    TblEstratoSocioEconomicoId = table.Column<int>(nullable: true),
                    TblEtniaId = table.Column<int>(nullable: true),
                    TblGeneroId = table.Column<int>(nullable: true),
                    TblIdentidaDeGeneroId = table.Column<int>(nullable: true),
                    TblJornadaDeTrabajoId = table.Column<int>(nullable: true),
                    TblLocalidadTrabajaId = table.Column<int>(nullable: true),
                    TblLocalidadViveId = table.Column<int>(nullable: true),
                    TblNivelDeEscolaridadId = table.Column<int>(nullable: true),
                    TblOrientacionId = table.Column<int>(nullable: true),
                    TblSeguridadSocialId = table.Column<int>(nullable: true),
                    TblSubsidioId = table.Column<int>(nullable: true),
                    TblTipoDeViviendaId = table.Column<int>(nullable: true),
                    TblTipoDocumentoId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblDiscapacidad_TblDiscapacidadId",
                        column: x => x.TblDiscapacidadId,
                        principalTable: "TblDiscapacidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblEstratoSocioEconomico_TblEstratoSocioEconomicoId",
                        column: x => x.TblEstratoSocioEconomicoId,
                        principalTable: "TblEstratoSocioEconomico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblEtnia_TblEtniaId",
                        column: x => x.TblEtniaId,
                        principalTable: "TblEtnia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblGenero_TblGeneroId",
                        column: x => x.TblGeneroId,
                        principalTable: "TblGenero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblIdentidaDeGenero_TblIdentidaDeGeneroId",
                        column: x => x.TblIdentidaDeGeneroId,
                        principalTable: "TblIdentidaDeGenero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblJornadaDeTrabajo_TblJornadaDeTrabajoId",
                        column: x => x.TblJornadaDeTrabajoId,
                        principalTable: "TblJornadaDeTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblLocalidadTrabaja_TblLocalidadTrabajaId",
                        column: x => x.TblLocalidadTrabajaId,
                        principalTable: "TblLocalidadTrabaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblLocalidadVive_TblLocalidadViveId",
                        column: x => x.TblLocalidadViveId,
                        principalTable: "TblLocalidadVive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblNivelDeEscolaridad_TblNivelDeEscolaridadId",
                        column: x => x.TblNivelDeEscolaridadId,
                        principalTable: "TblNivelDeEscolaridad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblOrientacion_TblOrientacionId",
                        column: x => x.TblOrientacionId,
                        principalTable: "TblOrientacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblSeguridadSocial_TblSeguridadSocialId",
                        column: x => x.TblSeguridadSocialId,
                        principalTable: "TblSeguridadSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblSubsidio_TblSubsidioId",
                        column: x => x.TblSubsidioId,
                        principalTable: "TblSubsidio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblTipoDeVivienda_TblTipoDeViviendaId",
                        column: x => x.TblTipoDeViviendaId,
                        principalTable: "TblTipoDeVivienda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_TblTipoDocumento_TblTipoDocumentoId",
                        column: x => x.TblTipoDocumentoId,
                        principalTable: "TblTipoDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPersona_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblDiscapacidadId",
                table: "tblPersona",
                column: "TblDiscapacidadId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblEstratoSocioEconomicoId",
                table: "tblPersona",
                column: "TblEstratoSocioEconomicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblEtniaId",
                table: "tblPersona",
                column: "TblEtniaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblGeneroId",
                table: "tblPersona",
                column: "TblGeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblIdentidaDeGeneroId",
                table: "tblPersona",
                column: "TblIdentidaDeGeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblJornadaDeTrabajoId",
                table: "tblPersona",
                column: "TblJornadaDeTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblLocalidadTrabajaId",
                table: "tblPersona",
                column: "TblLocalidadTrabajaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblLocalidadViveId",
                table: "tblPersona",
                column: "TblLocalidadViveId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblNivelDeEscolaridadId",
                table: "tblPersona",
                column: "TblNivelDeEscolaridadId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblOrientacionId",
                table: "tblPersona",
                column: "TblOrientacionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblSeguridadSocialId",
                table: "tblPersona",
                column: "TblSeguridadSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblSubsidioId",
                table: "tblPersona",
                column: "TblSubsidioId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblTipoDeViviendaId",
                table: "tblPersona",
                column: "TblTipoDeViviendaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_TblTipoDocumentoId",
                table: "tblPersona",
                column: "TblTipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersona_UsuarioId",
                table: "tblPersona",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "tblPersona");

            migrationBuilder.DropTable(
                name: "TblDiscapacidad");

            migrationBuilder.DropTable(
                name: "TblEstratoSocioEconomico");

            migrationBuilder.DropTable(
                name: "TblEtnia");

            migrationBuilder.DropTable(
                name: "TblGenero");

            migrationBuilder.DropTable(
                name: "TblIdentidaDeGenero");

            migrationBuilder.DropTable(
                name: "TblJornadaDeTrabajo");

            migrationBuilder.DropTable(
                name: "TblLocalidadTrabaja");

            migrationBuilder.DropTable(
                name: "TblLocalidadVive");

            migrationBuilder.DropTable(
                name: "TblNivelDeEscolaridad");

            migrationBuilder.DropTable(
                name: "TblOrientacion");

            migrationBuilder.DropTable(
                name: "TblSeguridadSocial");

            migrationBuilder.DropTable(
                name: "TblSubsidio");

            migrationBuilder.DropTable(
                name: "TblTipoDeVivienda");

            migrationBuilder.DropTable(
                name: "TblTipoDocumento");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
