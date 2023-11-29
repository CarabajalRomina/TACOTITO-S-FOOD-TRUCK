using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.src.interfaces;
using Tacotitos.src.modelo.cliente;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.pedido;
using Tacotitos.src.modelo.taco;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.BD.Context
{
    public class TacotitosContext : DbContext
    {
        static TacotitosContext instance = new TacotitosContext();
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<DetalleIngrediente> DetallesIngredientes { get; set; }
        public DbSet<TipoIngrediente> TiposIngredientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Taco> Tacos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }



        public TacotitosContext() { }
        public static TacotitosContext GetContext()
        {
            return instance;
        }
        public TacotitosContext(DbContextOptions<TacotitosContext> options)
        : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connection = "Server=LAPTOP-2L63D3JF\\SQLEXPRESS;Database=Tacotitos;Trusted_Connection=True;Encrypt=false";
                optionsBuilder.UseSqlServer(connection);
            }
        }
    }
}
