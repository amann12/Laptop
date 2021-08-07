using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        //for creating Table in SQL Server
        public DbSet<Lappy> Laptop { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lappy>().HasData(
                new Lappy
                {
                    Id=1,
                    LaptopName="Omen",
                    NumberOfPorts=10,
                    Processor="i7",
                    GraphicCard="nvidia 1650ti",
                    RAM="16GB",
                    Memory="1TB SSD",
                    Screen="144hz",
                    Price= 113958

                },   
                new Lappy
                {
                    Id=2,
                    LaptopName="Pavilion Gaming",
                    NumberOfPorts=8,
                    Processor="i5",
                    GraphicCard="nvidia 1650",
                    RAM="8GB",
                    Memory="512GB SSD",
                    Screen="60hz",
                    Price= 60000

                }
                );
        }
    }
}
