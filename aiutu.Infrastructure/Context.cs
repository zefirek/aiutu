using aiutu.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Adres> Adresy { get; set; }                                        // Addresses
        public DbSet<DanaKontaktowa> DaneKontaktowe { get; set; }                       // ContactDetails
        public DbSet<DanaKontaktowaTyp> DanaKontaktowaTypy { get; set; }                // ContactDetailTypes
        public DbSet<Kontrahent> Kontrahenci { get; set; }                              // Customers
        public DbSet<KontrahentDanaKontaktowa> KontrahentDaneKontaktowe { get; set; }   // CustomerContactInformations
        public DbSet<Pojazd> Pojazdy { get; set; }                                      // Items
        public DbSet<PojazdRodzaj> PojazdRodzaje { get; set; }                          // Types
        public DbSet<PojazdTag> PojazdTag { get; set; }                                 // ItemTag
        public DbSet<Tag> Tagi { get; set; }                                            // Tags
        public DbSet<Wlasciciel> Wlasciciele { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Kontrahent>()
                .HasOne(a => a.KontrahentDaneKontaktowe).WithOne(b => b.Kontrahent)     // relacja jeden do jeden
                .HasForeignKey<KontrahentDanaKontaktowa>(e => e.KontrahentRef);         // klucz obcy

            builder.Entity<PojazdTag>()
                .HasKey(it => new { it.PojazdId, it.TagId });       // para kluczy - tydzień 7 - lekcja 5 - Context  11:47

            builder.Entity<PojazdTag>()                             // w tabeli pośredniczącej dla jednego pojazdu może być wiele powiązań z PojazdTag
                .HasOne<Pojazd>(it => it.Pojazd)
                .WithMany(i => i.PojazdTags)
                .HasForeignKey(it => it.PojazdId);

            builder.Entity<PojazdTag>()                             // j.w. jeden tag ma wiele PojazdTag klucz obcy
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.PojazdTags)
                .HasForeignKey(it => it.TagId);

        }
    }
}
