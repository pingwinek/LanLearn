using Dto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public interface ITranslateService
    {
        IEnumerable<EnglishDictionary> GetListWords(int account);
        EnglishDictionary GetTranslate(int translateId);
    }
}
