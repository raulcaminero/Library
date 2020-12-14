﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Dto.ListaServicio", b =>
                {
                    b.Property<int>("Servicio_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Campus_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Carrera_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EscuelaId")
                        .HasColumnType("int");

                    b.Property<string>("Escuela_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoId")
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Estado_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculta_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacultadId")
                        .HasColumnType("int");

                    b.Property<string>("Servicio_Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Servicio_Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Servicio_Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Servicio_FechaCierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Servicio_FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoServicio_Id")
                        .HasColumnType("int");

                    b.Property<string>("TipoServicio_Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Servicio_Id");

                    b.HasIndex("CampusId");

                    b.HasIndex("CarreraId");

                    b.HasIndex("EscuelaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("FacultadId");

                    b.ToTable("ListaServicio");
                });

            modelBuilder.Entity("WebApp.Models.AdjuntoMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Ruta")
                        .HasColumnName("ruta")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("adjuntoMaterial");
                });

            modelBuilder.Entity("WebApp.Models.Calificaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calificacion")
                        .HasColumnType("int");

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("ModuloId")
                        .HasColumnName("ModuloId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCodigo")
                        .HasColumnName("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("ModuloId");

                    b.HasIndex("UsuarioCodigo");

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("WebApp.Models.Campus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Campus_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CampusCodigo")
                        .IsRequired()
                        .HasColumnName("Campus_Codigo")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("CampusNombre")
                        .IsRequired()
                        .HasColumnName("Campus_Nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampusId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("WebApp.Models.Carrera", b =>
                {
                    b.Property<int>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Carrera_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampusId")
                        .HasColumnName("Campus_Id")
                        .HasColumnType("int");

                    b.Property<string>("CarreraCodigo")
                        .IsRequired()
                        .HasColumnName("Carrera_Codigo")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("CarreraNombre")
                        .IsRequired()
                        .HasColumnName("Carrera_Nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("EscuelaId")
                        .HasColumnName("Escuela_Id")
                        .HasColumnType("int");

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("FacultadId")
                        .HasColumnName("Facultad_Id")
                        .HasColumnType("int");

                    b.HasKey("CarreraId");

                    b.HasIndex("CampusId");

                    b.HasIndex("EscuelaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("FacultadId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("WebApp.Models.Escuela", b =>
                {
                    b.Property<int>("EscuelaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Escuela_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampusId")
                        .HasColumnName("Campus_Id")
                        .HasColumnType("int");

                    b.Property<string>("EscuelaCodigo")
                        .IsRequired()
                        .HasColumnName("Escuela_Codigo")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("EscuelaNombre")
                        .IsRequired()
                        .HasColumnName("Escuela_Nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("FacultadId")
                        .HasColumnName("Facultad_Id")
                        .HasColumnType("int");

                    b.HasKey("EscuelaId");

                    b.HasIndex("CampusId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("FacultadId");

                    b.ToTable("Escuelas");
                });

            modelBuilder.Entity("WebApp.Models.Estado", b =>
                {
                    b.Property<string>("EstadoId")
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("EstadoNombre")
                        .IsRequired()
                        .HasColumnName("Estado_Nombre")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("WebApp.Models.Facultad", b =>
                {
                    b.Property<int>("FacultadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Facultad_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampusId")
                        .HasColumnName("Campus_Id")
                        .HasColumnType("int");

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("FacultadCodigo")
                        .IsRequired()
                        .HasColumnName("Facultad_Codigo")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("FacultadNombre")
                        .IsRequired()
                        .HasColumnName("Facultad_Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NombreDecano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicación")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultadId");

                    b.HasIndex("CampusId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Facultades");
                });

            modelBuilder.Entity("WebApp.Models.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnName("fecha_fin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnName("fecha_inicio")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdAdjunto")
                        .HasColumnName("id_adjunto")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnName("imagen")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("ServicioId")
                        .HasColumnName("Servicio_Id")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnName("titulo")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int>("UsuarioCodigo")
                        .HasColumnName("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("IdAdjunto");

                    b.HasIndex("ServicioId");

                    b.HasIndex("UsuarioCodigo");

                    b.ToTable("Modulo");
                });

            modelBuilder.Entity("WebApp.Models.Requerimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoServicioId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("TipoServicioId");

                    b.ToTable("Requerimientos");
                });

            modelBuilder.Entity("WebApp.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("WebApp.Models.Servicio", b =>
                {
                    b.Property<int>("Servicio_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Servicio_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Campus_Id")
                        .HasColumnName("Campus_Id")
                        .HasColumnType("int");

                    b.Property<int>("Carrera_Id")
                        .HasColumnName("Carrera_Id")
                        .HasColumnType("int");

                    b.Property<int>("Escuela_Id")
                        .HasColumnName("Escuela_Id")
                        .HasColumnType("int");

                    b.Property<string>("Estado_Id")
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("('I')")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("Facultad_Id")
                        .HasColumnName("Facultad_Id")
                        .HasColumnType("int");

                    b.Property<string>("Servicio_Codigo")
                        .IsRequired()
                        .HasColumnName("Servicio_Codigo")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<decimal?>("Servicio_Costo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Servicio_Costo")
                        .HasColumnType("decimal(12, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Servicio_Descripcion")
                        .IsRequired()
                        .HasColumnName("Servicio_Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Servicio_FechaCierre")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Servicio_FechaCierre")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('')");

                    b.Property<DateTime?>("Servicio_FechaInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Servicio_FechaInicio")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("('')");

                    b.Property<int>("TipoServicio_Id")
                        .HasColumnName("TipoServicio_Id")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioCodigo")
                        .HasColumnName("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Servicio_Id");

                    b.HasIndex("Campus_Id");

                    b.HasIndex("Carrera_Id");

                    b.HasIndex("Escuela_Id");

                    b.HasIndex("Estado_Id");

                    b.HasIndex("UsuarioCodigo");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("WebApp.Models.TipoServicio", b =>
                {
                    b.Property<int>("TipoServicioId")
                        .HasColumnName("TipoServicio_Id")
                        .HasColumnType("int");

                    b.Property<string>("EstadoId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Estado_Id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("('A')")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("TipoServicioDescripcion")
                        .IsRequired()
                        .HasColumnName("TipoServicio_Descripcion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("TipoServicioId");

                    b.HasIndex("EstadoId");

                    b.ToTable("TipoServicios");
                });

            modelBuilder.Entity("WebApp.Models.Usuario", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoId")
                        .HasColumnType("varchar(1)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<int>("campus")
                        .HasColumnType("int");

                    b.Property<string>("contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigo");

                    b.HasIndex("EstadoId");

                    b.HasIndex("RolID");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("WebApp.Dto.ListaServicio", b =>
                {
                    b.HasOne("WebApp.Models.Campus", "Campus")
                        .WithMany()
                        .HasForeignKey("CampusId");

                    b.HasOne("WebApp.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId");

                    b.HasOne("WebApp.Models.Escuela", "Escuela")
                        .WithMany()
                        .HasForeignKey("EscuelaId");

                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");

                    b.HasOne("WebApp.Models.Facultad", "Facultad")
                        .WithMany()
                        .HasForeignKey("FacultadId");
                });

            modelBuilder.Entity("WebApp.Models.AdjuntoMaterial", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("AdjuntoMaterial")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_adjuntoMaterialEstado")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Calificaciones", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Calificaciones")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_CalificacionesEstado")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Modulo", "Modulo")
                        .WithMany("Calificaciones")
                        .HasForeignKey("ModuloId")
                        .HasConstraintName("FK_CalficaionesModulos")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Usuario", "Usuario")
                        .WithMany("Calificaciones")
                        .HasForeignKey("UsuarioCodigo")
                        .HasConstraintName("FK_CalificacionEstudiantes")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Campus", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Campus")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Campus_Estado")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Carrera", b =>
                {
                    b.HasOne("WebApp.Models.Campus", "Campus")
                        .WithMany("Carrera")
                        .HasForeignKey("CampusId")
                        .HasConstraintName("FK_Carrera_Campus")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Escuela", "Escuela")
                        .WithMany("Carrera")
                        .HasForeignKey("EscuelaId")
                        .HasConstraintName("FK_Carrera_Escuela")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Carrera")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Carrera_Estado")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Facultad", "Facultad")
                        .WithMany("Carrera")
                        .HasForeignKey("FacultadId")
                        .HasConstraintName("FK_Carrera_Facultad")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Escuela", b =>
                {
                    b.HasOne("WebApp.Models.Campus", "Campus")
                        .WithMany("Escuela")
                        .HasForeignKey("CampusId")
                        .HasConstraintName("FK_Escuela_Campus")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Escuela")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Escuela_Estado")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Facultad", "Facultad")
                        .WithMany("Escuela")
                        .HasForeignKey("FacultadId")
                        .HasConstraintName("FK_Escuela_Facultad")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Facultad", b =>
                {
                    b.HasOne("WebApp.Models.Campus", "Campus")
                        .WithMany("Facultad")
                        .HasForeignKey("CampusId")
                        .HasConstraintName("FK_Facultad_Campus")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Facultad")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Facultad_Estado")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Modulo", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Modulo")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_ModuloEstado")
                        .IsRequired();

                    b.HasOne("WebApp.Models.AdjuntoMaterial", "IdAdjuntoNavigation")
                        .WithMany("Modulo")
                        .HasForeignKey("IdAdjunto")
                        .HasConstraintName("FK_ModuloAdjunto");

                    b.HasOne("WebApp.Models.Servicio", "Servicio")
                        .WithMany("Modulo")
                        .HasForeignKey("ServicioId")
                        .HasConstraintName("FK_Modulo_Servicio")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Usuario", "IdProfesorNavigation")
                        .WithMany("Modulo")
                        .HasForeignKey("UsuarioCodigo")
                        .HasConstraintName("FK_ModuloProfesor")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Requerimiento", b =>
                {
                    b.HasOne("WebApp.Models.TipoServicio", "TipoServicio")
                        .WithMany()
                        .HasForeignKey("TipoServicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Servicio", b =>
                {
                    b.HasOne("WebApp.Models.Campus", "Campus")
                        .WithMany("Servicio")
                        .HasForeignKey("Campus_Id")
                        .HasConstraintName("FK_Servicio_Campus")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Carrera", "Carrera")
                        .WithMany("Servicio")
                        .HasForeignKey("Carrera_Id")
                        .HasConstraintName("FK_Servicio_Carrera")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Escuela", "Escuela")
                        .WithMany("Servicio")
                        .HasForeignKey("Escuela_Id")
                        .HasConstraintName("FK_Servicio_Escuela")
                        .IsRequired();

                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Servicio")
                        .HasForeignKey("Estado_Id")
                        .HasConstraintName("FK_Servicio_Estado");

                    b.HasOne("WebApp.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioCodigo");
                });

            modelBuilder.Entity("WebApp.Models.TipoServicio", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("TipoServicio")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_TipoServicio_Estado")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Usuario", b =>
                {
                    b.HasOne("WebApp.Models.Estado", "Estado")
                        .WithMany("Usuario")
                        .HasForeignKey("EstadoId");

                    b.HasOne("WebApp.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
