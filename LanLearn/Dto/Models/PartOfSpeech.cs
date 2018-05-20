using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.Models
{
    public class PartOfSpeech
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string PolishTranslate { get; set; }

        public ICollection<EnglishDictionary> EnglishDictionary { get; set; }
    }
}
