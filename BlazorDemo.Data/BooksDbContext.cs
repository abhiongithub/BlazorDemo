﻿using System;
using BlazorDemo.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Data
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }
    }
}