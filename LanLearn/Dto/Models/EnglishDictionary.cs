using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dto.Models
{
    public class EnglishDictionary
    {
        public int Id { get; set; }
        public string EnglishWord { get; set; }
        public string PolishTranslate { get; set; }
        public int Rank { get; set; }
        public int PartOfSpeechID { get; set; }

        public PartOfSpeech PartOfSpeech { get; set; }
    }
}
