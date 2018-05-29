using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dto.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string TranslateWord { get; set; }
    }
}
