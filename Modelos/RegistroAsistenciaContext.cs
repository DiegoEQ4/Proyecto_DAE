using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_DAE.Modelos;

public partial class RegistroAsistenciaContext : DbContext
{
    public RegistroAsistenciaContext()
    {
    }

    public RegistroAsistenciaContext(DbContextOptions<RegistroAsistenciaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asistencium> Asistencia { get; set; }

    public virtual DbSet<Clase> Clases { get; set; }

    public virtual DbSet<DetalleAsistencium> DetalleAsistencia { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<MateriaGrado> MateriaGrados { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Registro_Asistencia2;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asistencium>(entity =>
        {
            entity.HasKey(e => e.IdAsistencia).HasName("PK__Asistenc__20240AC42CFBB0B4");

            entity.Property(e => e.IdAsistencia).HasColumnName("Id_Asistencia");
            entity.Property(e => e.ClaseAsistencia).HasColumnName("Clase_Asistencia");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.FechaHoraFinal)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hora_Final");

            entity.HasOne(d => d.ClaseAsistenciaNavigation).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.ClaseAsistencia)
                .HasConstraintName("FK__Asistenci__Clase__4AB81AF0");
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.HasKey(e => e.IdClase).HasName("PK__Clase__E30692F08CCE6B16");

            entity.ToTable("Clase");

            entity.Property(e => e.IdClase).HasColumnName("Id_Clase");
            entity.Property(e => e.ContenidoClase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Contenido_Clase");
            entity.Property(e => e.DuracionHoras)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("Duracion_Horas");
            entity.Property(e => e.IdMateriaDetalle).HasColumnName("Id_Materia_Detalle");

            entity.HasOne(d => d.IdMateriaDetalleNavigation).WithMany(p => p.Clases)
                .HasForeignKey(d => d.IdMateriaDetalle)
                .HasConstraintName("FK__Clase__Id_Materi__47DBAE45");
        });

        modelBuilder.Entity<DetalleAsistencium>(entity =>
        {
            entity.HasKey(e => e.IdDetalleAsistencia).HasName("PK__Detalle___86017D19B743EC33");

            entity.ToTable("Detalle_Asistencia");

            entity.Property(e => e.IdDetalleAsistencia).HasColumnName("Id_Detalle_Asistencia");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdAsistencia).HasColumnName("Id_Asistencia");

            entity.HasOne(d => d.EstudianteNavigation).WithMany(p => p.DetalleAsistencia)
                .HasForeignKey(d => d.Estudiante)
                .HasConstraintName("FK__Detalle_A__Estud__4E88ABD4");

            entity.HasOne(d => d.IdAsistenciaNavigation).WithMany(p => p.DetalleAsistencia)
                .HasForeignKey(d => d.IdAsistencia)
                .HasConstraintName("FK__Detalle_A__Id_As__4D94879B");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.CarnetEstudiantes).HasName("PK__Estudian__2762B9AAD2FF0010");

            entity.Property(e => e.CarnetEstudiantes)
                .ValueGeneratedNever()
                .HasColumnName("Carnet_Estudiantes");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CorreoInstitucional)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Correo_Institucional");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.GradoNavigation).WithMany(p => p.Estudiantes)
                .HasForeignKey(d => d.Grado)
                .HasConstraintName("FK__Estudiant__Grado__3D5E1FD2");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.HasKey(e => e.IdGrado).HasName("PK__Grado__ADBED352FA1730FB");

            entity.ToTable("Grado");

            entity.Property(e => e.IdGrado).HasColumnName("Id_Grado");
            entity.Property(e => e.NombreGrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Grado");
            entity.Property(e => e.Seccion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__Materias__D3FE91FA7B6FF443");

            entity.Property(e => e.IdMateria).HasColumnName("Id_Materia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DuracionDias).HasColumnName("Duracion_Dias");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("Nombre_Materia");
        });

        modelBuilder.Entity<MateriaGrado>(entity =>
        {
            entity.HasKey(e => e.IdMateriaGrado).HasName("PK__Materia___79A8F709CAAAB7B4");

            entity.ToTable("Materia_Grado");

            entity.Property(e => e.IdMateriaGrado).HasColumnName("Id_Materia_Grado");
            entity.Property(e => e.IdGradoDetalle).HasColumnName("Id_Grado_Detalle");
            entity.Property(e => e.IdMateriaDetalle).HasColumnName("Id_Materia_Detalle");
            entity.Property(e => e.IdProfeDetalle).HasColumnName("Id_Profe_Detalle");

            entity.HasOne(d => d.IdGradoDetalleNavigation).WithMany(p => p.MateriaGrados)
                .HasForeignKey(d => d.IdGradoDetalle)
                .HasConstraintName("FK__Materia_G__Id_Gr__4316F928");

            entity.HasOne(d => d.IdMateriaDetalleNavigation).WithMany(p => p.MateriaGrados)
                .HasForeignKey(d => d.IdMateriaDetalle)
                .HasConstraintName("FK__Materia_G__Id_Ma__440B1D61");

            entity.HasOne(d => d.IdProfeDetalleNavigation).WithMany(p => p.MateriaGrados)
                .HasForeignKey(d => d.IdProfeDetalle)
                .HasConstraintName("FK__Materia_G__Id_Pr__44FF419A");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.CarnetProfesor).HasName("PK__Profesor__4D10BAD5D92D568B");

            entity.ToTable("Profesor");

            entity.Property(e => e.CarnetProfesor)
                .ValueGeneratedNever()
                .HasColumnName("Carnet_Profesor");
            entity.Property(e => e.CorreoInstitucional)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Correo_Institucional");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.NombreProfesor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Profesor");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Profesors)
                .HasForeignKey(d => d.Usuario)
                .HasConstraintName("FK__Profesor__Usuari__403A8C7D");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__63C76BE21E623533");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Nombre_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
