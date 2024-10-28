using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HansOrtizExamenProgreso1.Models;

    public class HansOrtizExamenProgreso1Context : DbContext
    {
        public HansOrtizExamenProgreso1Context (DbContextOptions<HansOrtizExamenProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<HansOrtizExamenProgreso1.Models.HO_Producto> HO_Producto { get; set; } = default!;
    }
