using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ElectionProject.Models.AuthorisationModel;
using ElectionProject.Models;

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
        public virtual DbSet<Circuit> Circuit { get; set; }
        public virtual DbSet<Citizen> Citizen { get; set; }
        public virtual DbSet<Complaint> Complaint { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Election> Election { get; set; }
        public virtual DbSet<HeadCircuit> HeadCircuit { get; set; }
        public virtual DbSet<HeadDistrict> HeadDistrict { get; set; }
        public virtual DbSet<Observer> Observer { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }

        public DbSet<User> Users { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Election;Username=postgres;Password=postgres");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appeal>(entity =>
            {
                entity.ToTable("appeal");

                entity.Property(e => e.AppealId).HasColumnName("appeal_id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("appeal_circuit_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Appeal)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appeal_citizen_id_fkey");

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

                entity.HasIndex(e => e.Number)
                    .HasName("candidate_number_key")
                    .IsUnique();

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

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

            modelBuilder.Entity<Circuit>(entity =>
            {
                entity.ToTable("circuit");

                entity.HasIndex(e => e.Address)
                    .HasName("circuit_address_key")
                    .IsUnique();

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Number).HasColumnName("number");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("citizen");

                entity.HasIndex(e => e.Ipn)
                    .HasName("citizen_ipn_key")
                    .IsUnique();

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.Birth)
                    .HasColumnName("birth")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Ipn)
                    .IsRequired()
                    .HasColumnName("ipn")
                    .HasColumnType("character varying(12)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasColumnType("character varying(30)");
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("complaint");

                entity.Property(e => e.ComplaintId).HasColumnName("complaint_id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.Property(e => e.ObserverId).HasColumnName("observer_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.Complaint)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("complaint_circuit_id_fkey");

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

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Center)
                    .IsRequired()
                    .HasColumnName("center")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_circuit_id_fkey");
            });

            modelBuilder.Entity<Election>(entity =>
            {
                entity.ToTable("election");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

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

            modelBuilder.Entity<HeadCircuit>(entity =>
            {
                entity.ToTable("head_circuit");

                entity.Property(e => e.HeadCircuitId).HasColumnName("head_circuit_id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.HeadCircuit)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("head_circuit_circuit_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.HeadCircuit)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("head_circuit_citizen_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.HeadCircuit)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("head_circuit_election_id_fkey");
            });

            modelBuilder.Entity<HeadDistrict>(entity =>
            {
                entity.HasKey(e => e.HeadDistrict1);

                entity.ToTable("head_district");

                entity.Property(e => e.HeadDistrict1).HasColumnName("head_district");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.HeadDistrict)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("head_district_citizen_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.HeadDistrict)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("head_district_district_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.HeadDistrict)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("head_district_election_id_fkey");
            });

            modelBuilder.Entity<Observer>(entity =>
            {
                entity.ToTable("observer");

                entity.Property(e => e.ObserverId).HasColumnName("observer_id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("observer_candidate_id_fkey");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("observer_circuit_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("observer_citizen_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Observer)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("observer_election_id_fkey");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(30)");
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.ToTable("vote");

                entity.HasIndex(e => e.CitizenId)
                    .HasName("vote_citizen_id_key")
                    .IsUnique();

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.CircuitId).HasColumnName("circuit_id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.ElectionId).HasColumnName("election_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vote_candidate_id_fkey");

                entity.HasOne(d => d.Circuit)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.CircuitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("vote_circuit_id_fkey");

                entity.HasOne(d => d.Citizen)
                    .WithOne(p => p.Vote)
                    .HasForeignKey<Vote>(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vote_citizen_id_fkey");

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Vote)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("vote_election_id_fkey");
            });
        }
    }
}
