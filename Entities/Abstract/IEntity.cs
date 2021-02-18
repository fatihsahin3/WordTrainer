using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        int CategoryId { get; set; }
        string TextInLanguage1 { get; set; }
        string TextInLanguage2 { get; set; }
        string SentenceInLanguage1 { get; set; }
        string SentenceInLanguage2 { get; set; }
    }
}
