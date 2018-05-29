using Dto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public interface ITranslateService
    {
        IEnumerable<EnglishDictionary> GetListWords(int account);
        void SendTranslate(string[] translate);
    }
}
