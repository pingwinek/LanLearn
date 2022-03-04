using Dto;
using Dto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanLearn.Service
{
    public class TranslateService : ITranslateService
    {
        private readonly LanLearnDbContext _context;

        public TranslateService(LanLearnDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EnglishDictionary> GetListWords(int count)
        {
            return _context.EnglishDictionaries.Take(count);
        }

        public EnglishDictionary GetTranslate(int translateId)
        {
            return _context.EnglishDictionaries.FirstOrDefault(x => x.Id == translateId);
        }

        public void SendTranslate(string[] value)
        {
            throw new NotImplementedException();
        }
    }
}
