using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDMaster.Models.DB;

public partial class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
    }

    public AcademiaContext(DbContextOptions<AcademiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Apoderado> Apoderados { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Calificacione> Calificaciones { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<CursoAlumno> CursoAlumnos { get; set; }

    public virtual DbSet<CursoProfesor> CursoProfesors { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-DKT85JI;Initial Catalog=Academia;User ID=sa;\nIntegrated Security=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.Idalumno).HasName("XPKAlumno");

            entity.ToTable("Alumno");

            entity.Property(e => e.Idalumno)
                .ValueGeneratedNever()
                .HasColumnName("idalumno");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Idpersona).HasColumnName("idpersona");

            entity.HasOne(d => d.IdpersonaNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.Idpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_43");
        });

        modelBuilder.Entity<Apoderado>(entity =>
        {
            entity.HasKey(e => e.Idapoderado).HasName("XPKApoderado");

            entity.ToTable("Apoderado");

            entity.Property(e => e.Idapoderado)
                .ValueGeneratedNever()
                .HasColumnName("idapoderado");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.Idpersona).HasColumnName("idpersona");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdpersonaNavigation).WithMany(p => p.Apoderados)
                .HasForeignKey(d => d.Idpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_44");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.IdAula).HasName("XPKAula");

            entity.ToTable("Aula");

            entity.Property(e => e.IdAula)
                .ValueGeneratedNever()
                .HasColumnName("id_aula");
            entity.Property(e => e.Capacidad)
                .HasMaxLength(3)
                .HasColumnName("capacidad");
            entity.Property(e => e.CodigAula)
                .HasMaxLength(10)
                .HasColumnName("codig_Aula");
        });

        modelBuilder.Entity<Calificacione>(entity =>
        {
            entity.HasKey(e => e.Idcalificaciones).HasName("XPKCalificaciones");

            entity.Property(e => e.Idcalificaciones)
                .ValueGeneratedNever()
                .HasColumnName("idcalificaciones");
            entity.Property(e => e.Idalumno).HasColumnName("idalumno");
            entity.Property(e => e.IdcursoAlumno).HasColumnName("idcursoAlumno");
            entity.Property(e => e.Idprofesor).HasColumnName("idprofesor");
            entity.Property(e => e.Nota)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nota");

            entity.HasOne(d => d.IdalumnoNavigation).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.Idalumno)
                .HasConstraintName("R_105");

            entity.HasOne(d => d.IdcursoAlumnoNavigation).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.IdcursoAlumno)
                .HasConstraintName("R_104");

            entity.HasOne(d => d.IdprofesorNavigation).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.Idprofesor)
                .HasConstraintName("R_106");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Idcurso).HasName("XPKCurso");

            entity.ToTable("Curso");

            entity.Property(e => e.Idcurso)
                .ValueGeneratedNever()
                .HasColumnName("idcurso");
            entity.Property(e => e.Horario)
                .HasColumnType("datetime")
                .HasColumnName("horario");
            entity.Property(e => e.IdGrados).HasColumnName("idGrados");
            entity.Property(e => e.NomCurso)
                .HasMaxLength(30)
                .HasColumnName("nomCurso");

            entity.HasOne(d => d.IdGradosNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdGrados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_103");
        });

        modelBuilder.Entity<CursoAlumno>(entity =>
        {
            entity.HasKey(e => e.IdcursoAlumno).HasName("XPKCursoAlumno");

            entity.ToTable("CursoAlumno");

            entity.Property(e => e.IdcursoAlumno)
                .ValueGeneratedNever()
                .HasColumnName("idcursoAlumno");
            entity.Property(e => e.Idalumno).HasColumnName("idalumno");
            entity.Property(e => e.Idcurso).HasColumnName("idcurso");

            entity.HasOne(d => d.IdalumnoNavigation).WithMany(p => p.CursoAlumnos)
                .HasForeignKey(d => d.Idalumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_95");

            entity.HasOne(d => d.IdcursoNavigation).WithMany(p => p.CursoAlumnos)
                .HasForeignKey(d => d.Idcurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_93");
        });

        modelBuilder.Entity<CursoProfesor>(entity =>
        {
            entity.HasKey(e => e.IdcursoProfesor).HasName("XPKCurso_Profesor");

            entity.ToTable("Curso_Profesor");

            entity.Property(e => e.IdcursoProfesor)
                .ValueGeneratedNever()
                .HasColumnName("idcursoProfesor");
            entity.Property(e => e.Idcurso).HasColumnName("idcurso");
            entity.Property(e => e.Idprofesor).HasColumnName("idprofesor");

            entity.HasOne(d => d.IdcursoNavigation).WithMany(p => p.CursoProfesors)
                .HasForeignKey(d => d.Idcurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_94");

            entity.HasOne(d => d.IdprofesorNavigation).WithMany(p => p.CursoProfesors)
                .HasForeignKey(d => d.Idprofesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_70");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.HasKey(e => e.IdGrados).HasName("XPKGrados");

            entity.Property(e => e.IdGrados)
                .ValueGeneratedNever()
                .HasColumnName("idGrados");
            entity.Property(e => e.IdAula).HasColumnName("id_aula");
            entity.Property(e => e.NomGrados)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomGrados");

            entity.HasOne(d => d.IdAulaNavigation).WithMany(p => p.Grados)
                .HasForeignKey(d => d.IdAula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_67");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.HasKey(e => e.IdMatricula).HasName("XPKMatricula");

            entity.ToTable("Matricula");

            entity.Property(e => e.IdMatricula)
                .ValueGeneratedNever()
                .HasColumnName("idMatricula");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.Idalumno).HasColumnName("idalumno");
            entity.Property(e => e.Idapoderado).HasColumnName("idapoderado");
            entity.Property(e => e.Turno)
                .HasMaxLength(18)
                .HasColumnName("turno");

            entity.HasOne(d => d.IdalumnoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Idalumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_27");

            entity.HasOne(d => d.IdapoderadoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Idapoderado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_57");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Idpersona).HasName("XPKPersona");

            entity.ToTable("Persona");

            entity.Property(e => e.Idpersona)
                .ValueGeneratedNever()
                .HasColumnName("idpersona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("direccion");
            entity.Property(e => e.Edad)
                .HasMaxLength(10)
                .HasColumnName("edad");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDocumento)
                .HasMaxLength(18)
                .HasColumnName("nro_documento");
            entity.Property(e => e.Sexo)
                .HasMaxLength(18)
                .HasColumnName("sexo");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("R_102");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.Idprofesor).HasName("XPKProfesor");

            entity.ToTable("Profesor");

            entity.Property(e => e.Idprofesor)
                .ValueGeneratedNever()
                .HasColumnName("idprofesor");
            entity.Property(e => e.EmailProfesor)
                .HasMaxLength(30)
                .HasColumnName("email_Profesor");
            entity.Property(e => e.Idpersona).HasColumnName("idpersona");

            entity.HasOne(d => d.IdpersonaNavigation).WithMany(p => p.Profesors)
                .HasForeignKey(d => d.Idpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_45");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("XPKRol");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Rol1)
                .HasMaxLength(18)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("XPKTipo_Documento");

            entity.ToTable("Tipo_Documento");

            entity.Property(e => e.IdTipoDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_tipoDocumento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKUsuario");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(18)
                .HasColumnName("contraseña");
            entity.Property(e => e.Email)
                .HasMaxLength(18)
                .HasColumnName("email");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_22");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
