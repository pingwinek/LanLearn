﻿using Dto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public class LanLearnDbContext : DbContext
    {
        public LanLearnDbContext()
        {
        }

        public LanLearnDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<EnglishDictionary> EnglishDictionaries { get; set; }
        public virtual DbSet<PartOfSpeech> PartsOfSpeech { get; set; }
    }
}
