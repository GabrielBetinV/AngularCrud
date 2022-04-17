using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using FBTarjetaCreedito.Models;




namespace FBTarjetaCreedito
{
    public class ApplicationDbContext : DbContext
    {
        // Configuramos los Db Set para mapear los datos

       public  DbSet<TarjetaCredito> TarjetaCredito { get; set; }



        // creamos controlador
     

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }




}
}
