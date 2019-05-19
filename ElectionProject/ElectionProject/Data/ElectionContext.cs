using System;
using ElectionProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ElectionProject
{
    public partial class ElectionContext : DbContext
    {
        public ElectionContext()
        {
        }

        public ElectionContext(DbContextOptions<ElectionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appeal> Appeal { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<CheckUpdates> CheckUpdates { get; set; }
        public virtual DbSet<Circuit> Circuit { get; set; }
        public virtual DbSet<CircuitHead> CircuitHead { get; set; }
        public virtual DbSet<Citizen> Citizen { get; set; }
        public virtual DbSet<Complaint> Complaint { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DistrictHead> DistrictHead { get; set; }
        public virtual DbSet<Election> Election { get; set; }
        public virtual DbSet<Observer> Observer { get; set; }
        public virtual DbSet<Models.Type> Type { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Election;Username=postgres;Password=wolf");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appeal>(entity =>
            {
                entity.ToTable("appeal");

                entity.HasIndex(e => e.CitizenId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.TypeId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appeal_citizen_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("appeal_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("appeal_election_id_fkey");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appeal_type_id_fkey");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("candidate");

                entity.HasIndex(e => e.CitizenId);

                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.Number)
                    .HasName("candidate_number_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("candidate_citizen_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("candidate_election_id_fkey");
            });

            modelBuilder.Entity<CheckUpdates>(entity =>
            {
                entity.ToTable("check_updates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.UpdatesCount).HasColumnName("updates_count");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.CheckUpdates)
                    .HasForeignKey(d => d.CitizenId)
                    .HasConstraintName("check_updates_citizen_id_fkey");
            });

            modelBuilder.Entity<Circuit>(entity =>
            {
                entity.ToTable("circuit");

                entity.HasIndex(e => e.Address)
                    .HasName("circuit_address_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying(75)");

                entity.Property(e => e.Center)
                    .IsRequired()
                    .HasColumnName("center")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");
            });

            modelBuilder.Entity<CircuitHead>(entity =>
            {
                entity.ToTable("circuit_head");

                entity.HasIndex(e => e.CircuitId);

                entity.HasIndex(e => e.CitizenId);

                entity.HasIndex(e => e.ElectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.CircuitHead)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("circuit_head_circuit_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.CircuitHead)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("circuit_head_citizen_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.CircuitHead)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("circuit_head_election_id_fkey");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("citizen");

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.Ipn)
                    .HasName("citizen_ipn_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Ipn)
                    .IsRequired()
                    .HasColumnName("ipn")
                    .HasColumnType("character varying(12)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasColumnName("middle_name")
                    .HasColumnType("character varying(30)");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Citizen)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("fk_citizen_district");
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("complaint");

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.ObserverId);

                entity.HasIndex(e => e.TypeId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.Property(e => e.ObserverId).HasColumnName("observer_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Complaint)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("complaint_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Complaint)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("complaint_election_id_fkey");

                entity.HasOne(d => d.Observer)
                    .WithMany(p => p.Complaint)
                    .HasForeignKey(d => d.ObserverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("complaint_observer_id_fkey");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Complaint)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("complaint_type_id_fkey");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("district");

                entity.HasIndex(e => e.Address)
                    .HasName("district_address_key")
                    .IsUnique();

                entity.HasIndex(e => e.CircuitId);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying(75)");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_circuit_id_fkey");
            });

            modelBuilder.Entity<DistrictHead>(entity =>
            {
                entity.ToTable("district_head");

                entity.HasIndex(e => e.CitizenId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ElectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.DistrictHead)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_head_citizen_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.DistrictHead)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("district_head_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.DistrictHead)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("district_head_election_id_fkey");
            });

            modelBuilder.Entity<Election>(entity =>
            {
                entity.ToTable("election");

                entity.HasIndex(e => e.HeadOfCvk);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.HeadOfCvk).HasColumnName("head_of_cvk");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Tour).HasColumnName("tour");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.HeadOfCvkNavigation)
                    .WithMany(p => p.Election)
                    .HasForeignKey(d => d.HeadOfCvk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("election_head_of_cvk_fkey");
            });

            modelBuilder.Entity<Observer>(entity =>
            {
                entity.ToTable("observer");

                entity.HasIndex(e => e.CandidateId);

                entity.HasIndex(e => e.CitizenId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ElectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("observer_candidate_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("observer_citizen_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("observer_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("observer_election_id_fkey");
            });

            modelBuilder.Entity<Models.Type>(entity =>
            {
                entity.ToTable("type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.ToTable("vote");

                entity.HasIndex(e => e.CandidateId);

                entity.HasIndex(e => e.CitizenId)
                    .HasName("vote_citizen_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.ElectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vote_candidate_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithOne(p => p.Vote)
                    .HasForeignKey<Vote>(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vote_citizen_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("vote_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("vote_election_id_fkey");
            });
        }
    }
}
