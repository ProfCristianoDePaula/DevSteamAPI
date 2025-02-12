﻿using DevSteamAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using devSteamAPI.Models;

namespace DevSteamAPI.Data
{
    public class DevSteamAPIContext : IdentityDbContext
    {
        //Metodo Construtor
        public DevSteamAPIContext(DbContextOptions<DevSteamAPIContext> options) : base(options)
        { }

        //Definir as tabelas do banco de dados
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //Sobrescrever o metodo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Jogo>().ToTable("Jogos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
        }
        public DbSet<DevSteamAPI.Models.Carrinho> Carrinho { get; set; } = default!;
        public DbSet<devSteamAPI.Models.ItemCarrinho> ItemCarrinho { get; set; } = default!;
        public DbSet<DevSteamAPI.Models.Usuario> Usuario { get; set; } = default!;
    }
}
