using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationDatabase.Context 
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3MNQSH8\\SQLSERVER;Initial Catalog= ApplicationDatabase;Integrated Security=True;Connect Timeout=10;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-3MNQSH8\\SQLSERVER;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust_Server_Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                base.OnModelCreating(modelBuilder);
                
            }
            catch (Exception ex)
            {

            }
        }
    }
        
 }

