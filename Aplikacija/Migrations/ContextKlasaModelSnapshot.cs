﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Aplikacija.Migrations
{
    [DbContext(typeof(ContextKlasa))]
    partial class ContextKlasaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("SalonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("SalonID");

                    b.ToTable("Komentari");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Godina")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SalonID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SalonID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaZaposlenja")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plata")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("RadniStaz")
                        .HasColumnType("int");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<string>("Skola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipRadnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SalonID");

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("Models.Salon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaOsnivanja")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIB")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VlasnikSalonaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VlasnikSalonaID");

                    b.ToTable("Saloni");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikID")
                        .HasColumnType("int");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<int>("UkupnaCena")
                        .HasColumnType("int");

                    b.Property<DateTime>("VremeKraja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VremePocetka")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RadnikID");

                    b.HasIndex("SalonID");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("Models.Usluga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("ImeUsluge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<int?>("TerminID")
                        .HasColumnType("int");

                    b.Property<string>("TipUsluge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VremeTrajanja")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SalonID");

                    b.HasIndex("TerminID");

                    b.ToTable("Usluge");
                });

            modelBuilder.Entity("Models.Vlasnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("VlasnikOd")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vlasnici");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("ListaKomentara")
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaKomentara")
                        .HasForeignKey("SalonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaKorisnika")
                        .HasForeignKey("SalonID");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaProizvoda")
                        .HasForeignKey("SalonID");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaRadnika")
                        .HasForeignKey("SalonID");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Models.Salon", b =>
                {
                    b.HasOne("Models.Vlasnik", "VlasnikSalona")
                        .WithMany()
                        .HasForeignKey("VlasnikSalonaID");

                    b.Navigation("VlasnikSalona");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("ListaTermina")
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany("ListaTermina")
                        .HasForeignKey("RadnikID");

                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaTermina")
                        .HasForeignKey("SalonID");

                    b.Navigation("Korisnik");

                    b.Navigation("Radnik");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Models.Usluga", b =>
                {
                    b.HasOne("Models.Salon", "Salon")
                        .WithMany("ListaUsluga")
                        .HasForeignKey("SalonID");

                    b.HasOne("Models.Termin", "Termin")
                        .WithMany("ListaUsluga")
                        .HasForeignKey("TerminID");

                    b.Navigation("Salon");

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("ListaKomentara");

                    b.Navigation("ListaTermina");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.Navigation("ListaTermina");
                });

            modelBuilder.Entity("Models.Salon", b =>
                {
                    b.Navigation("ListaKomentara");

                    b.Navigation("ListaKorisnika");

                    b.Navigation("ListaProizvoda");

                    b.Navigation("ListaRadnika");

                    b.Navigation("ListaTermina");

                    b.Navigation("ListaUsluga");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.Navigation("ListaUsluga");
                });
#pragma warning restore 612, 618
        }
    }
}
