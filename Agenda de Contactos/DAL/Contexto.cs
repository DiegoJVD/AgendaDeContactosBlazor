﻿using Agenda_de_Contactos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Contactos.DAL
{
    public class Contexto : DbContext
    {
    public DbSet<Contactos> Contactos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data\AgendaContactos.db");
        }
    }
}
