using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dto.Migrations.Seed
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<LanLearnDbContext>();
            context.Database.EnsureCreated();
            if (!context.EnglishDictionaries.Any())
            {
                //context.EnglishDictionaries.Add(new EnglishDictionary());

                context.EnglishDictionaries.Update(new EnglishDictionary()
                {
                    EnglishWord = "horse",
                    PolishTranslate = "koń",
                    Rank = 1286
                });

                //context.Set<EnglishDictionary>().Add(eng);
                context.SaveChanges();
            }
        }
    }
}
