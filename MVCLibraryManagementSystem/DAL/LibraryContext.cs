﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCLibraryManagementSystem.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCLibraryManagementSystem.DAL
{
    public class LibraryContext : IdentityDbContext<LibraryUser>
    {
        public LibraryContext() : base("name=Library")
        {

        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Newspaper> Newspapers { get; set; }
        public virtual DbSet<QuestionPaper> QuestionPapers { get; set; }
        public virtual DbSet<AccessionRecord> AccessionRecords { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<IssuedItem> IssuedItems { get; set; }
    }
}