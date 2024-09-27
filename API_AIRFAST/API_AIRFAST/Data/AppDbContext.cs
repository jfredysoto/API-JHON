﻿using API_AIRFAST.Models;
using Microsoft.EntityFrameworkCore;

namespace API_AIRFAST.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<UsuarioModel> Usuarios { get; set; }
}
