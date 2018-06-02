using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
                var partsOfSpeech = new PartOfSpeech[]
            {
                new PartOfSpeech() { Name = "noun", Symbol = "n", PolishTranslate = "rzeczownik" },
                new PartOfSpeech() { Name = "verb", Symbol = "v", PolishTranslate = "czasownik" },
                new PartOfSpeech() { Name = "adjective", Symbol = "adj", PolishTranslate = "przymiotnik" },
                new PartOfSpeech() { Name = "adverb", Symbol = "adv", PolishTranslate = "przysłówek" },
                new PartOfSpeech() { Name = "pronoun", Symbol = "pron", PolishTranslate = "zaimek" },
                new PartOfSpeech() { Name = "preposition", Symbol = "prep", PolishTranslate = "przyimek" },
                new PartOfSpeech() { Name = "conjunction", Symbol = "con", PolishTranslate = "spójnik" }
            };

                foreach (PartOfSpeech d in partsOfSpeech)
                {
                    context.PartsOfSpeech.Add(d);
                }
                context.SaveChanges();

                var words = new List<EnglishDictionary>
            {
                new EnglishDictionary() { EnglishWord = "horse", PolishTranslate = "koń", Rank = 1286, PartOfSpeechID = 1 },
                new EnglishDictionary() { EnglishWord = "eat", PolishTranslate = "jeść", Rank = 544, PartOfSpeechID = 2 },
                new EnglishDictionary() { EnglishWord = "teach", PolishTranslate = "nauczać", Rank = 546, PartOfSpeechID = 2 },
                new EnglishDictionary() { EnglishWord = "about", PolishTranslate = "o", Rank = 46, PartOfSpeechID = 6 },
                new EnglishDictionary() { EnglishWord = "play", PolishTranslate = "grać", Rank = 200, PartOfSpeechID = 2 },
                new EnglishDictionary() { EnglishWord = "start", PolishTranslate = "zaczynać", Rank = 173, PartOfSpeechID = 2 },
                new EnglishDictionary() { EnglishWord = "company", PolishTranslate = "firma", Rank = 189, PartOfSpeechID = 1 },
                new EnglishDictionary() { EnglishWord = "work", PolishTranslate = "praca", Rank = 199, PartOfSpeechID = 1 }
            };

                foreach (EnglishDictionary d in words)
                {
                    context.EnglishDictionaries.Add(d);
                }
                context.SaveChanges();
            }
        }
    }
}
