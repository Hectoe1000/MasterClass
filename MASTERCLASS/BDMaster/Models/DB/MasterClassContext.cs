using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDMaster.Models.DB;

public partial class MasterClassContext : DbContext
{
    public MasterClassContext()
    {
    }

    public MasterClassContext(DbContextOptions<MasterClassContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Apoderado> Apoderados { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<DetalleExam> DetalleExams { get; set; }

    public virtual DbSet<Examan> Examen { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<Nivel> Nivels { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-DKT85JI;Initial Catalog=MasterClass;User ID=sa;\nIntegrated Security=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.IdAlumno).HasName("XPKAlumno");

            entity.ToTable("Alumno");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.IdApoderado).HasColumnName("id_apoderado");
            entity.Property(e => e.IdNivel).HasColumnName("id_nivel");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");

            entity.HasOne(d => d.IdApoderadoNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdApoderado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_25");

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdNivel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_23");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_43");
        });

        modelBuilder.Entity<Apoderado>(entity =>
        {
            entity.HasKey(e => e.IdApoderado).HasName("XPKApoderado");

            entity.ToTable("Apoderado");

            entity.Property(e => e.IdApoderado).HasColumnName("id_apoderado");
            entity.Property(e => e.Email)
                .HasMaxLength(18)
                .HasColumnName("email");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Telefono)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Apoderados)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_44");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.IdAula).HasName("XPKAula");

            entity.ToTable("Aula");

            entity.Property(e => e.IdAula).HasColumnName("id_aula");
            entity.Property(e => e.Capacidad)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("capacidad");
            entity.Property(e => e.CodigAula)
                .HasMaxLength(10)
                .HasColumnName("codig_Aula");
            entity.Property(e => e.Turno)
                .HasMaxLength(18)
                .HasColumnName("turno");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("XPKCurso");

            entity.ToTable("Curso");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdNivel).HasColumnName("id_nivel");
            entity.Property(e => e.NomCurso)
                .HasMaxLength(30)
                .HasColumnName("nomCurso");

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdNivel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_37");
        });

        modelBuilder.Entity<DetalleExam>(entity =>
        {
            entity.HasKey(e => e.IdDetalleExam).HasName("XPKDetalle_exam");

            entity.ToTable("Detalle_exam");

            entity.Property(e => e.IdDetalleExam).HasColumnName("id_detalle_exam");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdExamen).HasColumnName("id_examen");
            entity.Property(e => e.PuntajeCurso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntaje_curso");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.DetalleExams)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_39");

            entity.HasOne(d => d.IdExamenNavigation).WithMany(p => p.DetalleExams)
                .HasForeignKey(d => d.IdExamen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_40");
        });

        modelBuilder.Entity<Examan>(entity =>
        {
            entity.HasKey(e => e.IdExamen).HasName("XPKExamen");

            entity.Property(e => e.IdExamen).HasColumnName("id_examen");
            entity.Property(e => e.FechaExam)
                .HasColumnType("datetime")
                .HasColumnName("fecha_exam");
            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.PregAcertadas)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("preg_acertadas");
            entity.Property(e => e.PregEquivocadas)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("preg_equivocadas");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Examen)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_41");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("XPKHorario");

            entity.ToTable("Horario");

            entity.Property(e => e.IdHorario)
                .ValueGeneratedNever()
                .HasColumnName("id_horario");
            entity.Property(e => e.FinClases)
                .HasColumnType("datetime")
                .HasColumnName("fin_clases");
            entity.Property(e => e.IdAula)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_aula");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.IniClases)
                .HasColumnType("datetime")
                .HasColumnName("ini_clases");

            entity.HasOne(d => d.IdAulaNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdAula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_36");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_35");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_38");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.HasKey(e => e.IdMatricula).HasName("XPKMatricula");

            entity.ToTable("Matricula");

            entity.Property(e => e.IdMatricula).HasColumnName("id_Matricula");
            entity.Property(e => e.FechaMatricula)
                .HasColumnType("datetime")
                .HasColumnName("fechaMatricula");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("fechaSalida");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.Turno)
                .HasMaxLength(18)
                .HasColumnName("turno");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_27");
        });

        modelBuilder.Entity<Nivel>(entity =>
        {
            entity.HasKey(e => e.IdNivel).HasName("XPKNivel");

            entity.ToTable("Nivel");

            entity.Property(e => e.IdNivel).HasColumnName("id_nivel");
            entity.Property(e => e.NomNivel)
                .HasMaxLength(30)
                .HasColumnName("nomNivel");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.IdNotas).HasName("XPKnotas");

            entity.ToTable("notas");

            entity.Property(e => e.IdNotas)
                .ValueGeneratedNever()
                .HasColumnName("id_notas");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdExamen)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_examen");
            entity.Property(e => e.Nota1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nota");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_33");

            entity.HasOne(d => d.IdExamenNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.IdExamen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_42");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKPersona");

            entity.ToTable("Persona");

            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(18)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(18)
                .HasColumnName("direccion");
            entity.Property(e => e.Edad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("edad");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(18)
                .HasColumnName("nombre");
            entity.Property(e => e.NroDocumento)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nro_documento");
            entity.Property(e => e.Sexo)
                .HasMaxLength(18)
                .HasColumnName("sexo");

            //entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Personas)
            //    .HasForeignKey(d => d.IdTipoDocumento)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("R_46");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.IdProfesor).HasName("XPKProfesor");

            entity.ToTable("Profesor");

            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.EmailProfesor)
                .HasMaxLength(18)
                .HasColumnName("email_Profesor");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Profesors)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_45");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("XPKRol");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Rol1)
                .HasMaxLength(18)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("XPKTipo_Documento");

            entity.ToTable("Tipo_Documento");

            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(18)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKUsuario");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
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
