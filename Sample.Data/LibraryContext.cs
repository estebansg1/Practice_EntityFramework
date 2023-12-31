﻿using Microsoft.EntityFrameworkCore;
using Sample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public string DbPath { get; }

        public LibraryContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "DbLibrary.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite($"Data Source={DbPath}");
    }
}
