﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context--Db tabloları ile proje classlarını bağlamak
    public class ContactContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Contact;Trusted_Connection=true"); //entityframeworke baglanacagi yeri söyledim
        }
        public DbSet<Contact> Contacts1 { get; set; }
    }
}
