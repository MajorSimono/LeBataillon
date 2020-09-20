using System;
using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Context
{
    public class LeBataillonDbContext : DbContext
    {

        public LeBataillonDbContext(DbContextOptions<LeBataillonDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var players = new List<Player>();

            for (int i = 1; i < 100; i++)
            {

                var name = SampleData.GenerateName(i);
                players.Add(new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), $"{name}", SampleData.GenerateLastName(i), SampleData.GenerateLevel()));
            }

            modelBuilder.Entity<Player>().HasData(players);

            var teams = new List<Team>();
            for (int i = 1; i < 10; i++)
            {
                teams.Add(new Team(i, SampleData.GenerateName(i + 1), i * 10));

            }
            modelBuilder.Entity<Team>().HasData(teams);

            var games = new List<Game>();

            for (int i = 1; i < 50; i++)
            {
                var today = DateTime.Now;
                var gameday = today.AddDays(i);
                var nombre = i * 1000;
                var equipe1 = SampleData.GenerateInteger(nombre + 9, 1, 9);
                var equipe2 = SampleData.GenerateInteger(nombre + 9, 1, 9);
                if (equipe1 == equipe2 && equipe2 != 9)
                {
                    equipe2 = equipe2 + 1;
                }
                else if (equipe1 == equipe2 && equipe2 == 9)
                {
                    equipe2 = equipe2 - 1;
                }

                games.Add(new Game(i, gameday, equipe1, equipe2));

            }
            modelBuilder.Entity<Game>().HasData(games);
        }
    }
}