using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Word : IEntity
    {
        private int _id;
        private int _categoryId;
        private string _textInLanguage1;
        private string _textInLanguage2;
        private string _sampleSentence;

        public int Id { get => _id; set => _id = value; }
        public int CategoryId { get => _categoryId; set => _categoryId = value; }
        public string TextInLanguage1 { get => _textInLanguage1; set => _textInLanguage1 = value; }
        public string TextInLanguage2 { get => _textInLanguage2; set => _textInLanguage2 = value; }
        public string SentenceInLanguage1 { get => _sampleSentence; set => _sampleSentence = value; }
        public string SentenceInLanguage2 { get => _sampleSentence; set => _sampleSentence = value; }
    }
}
