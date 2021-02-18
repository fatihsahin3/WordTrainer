using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryWordDal : IWordDal
    {
        List<Word> _wordList;

        public InMemoryWordDal()
        {
            _wordList = new List<Word> {
                new Word {Id = 1, CategoryId = 1, TextInLanguage1 = "maken", TextInLanguage2 = "to do", SentenceInLanguage1 = "Ik wil dit niet maken." },
                new Word {Id = 2, CategoryId = 1, TextInLanguage1 = "beslissen", TextInLanguage2 = "to decide", SentenceInLanguage1 = "Ik moet vandaag beslissen wat ik ga doen." },
                new Word {Id = 3, CategoryId = 1, TextInLanguage1 = "opslaan", TextInLanguage2 = "to save", SentenceInLanguage1 = "Ik heb mijn werk op Computer opgeslagen." },
                new Word {Id = 4, CategoryId = 1, TextInLanguage1 = "krimpen", TextInLanguage2 = "shrink", SentenceInLanguage1 = "Industrie krimpt zo lang Corona bestemming doorgaat." },
                new Word {Id = 5, CategoryId = 1, TextInLanguage1 = "verordelen", TextInLanguage2 = "to condemn", SentenceInLanguage1 = "Rutte verordeelt de rellen." },
                new Word {Id = 6, CategoryId = 2, TextInLanguage1 = "stok", TextInLanguage2 = "stick", SentenceInLanguage1 = "Oguz spelt met deze houte stok." },
                new Word {Id = 7, CategoryId = 2, TextInLanguage1 = "reden", TextInLanguage2 = "reason", SentenceInLanguage1 = "Het reden van deze rellen is nog niet klaar." },
                new Word {Id = 8, CategoryId = 2, TextInLanguage1 = "bestand", TextInLanguage2 = "file", SentenceInLanguage1 = "Ik hem mijn bestanden op de tafel gesteld." },
                new Word {Id = 9, CategoryId = 2, TextInLanguage1 = "eigenschap", TextInLanguage2 = "characteristic, feature", SentenceInLanguage1 = "Ik hou van je eigenschap." },
                new Word {Id = 10, CategoryId = 2, TextInLanguage1 = "schuld", TextInLanguage2 = "guilt, debt", SentenceInLanguage1 = "Je hebt geen schuld voor deze ongeluk." },
                new Word {Id = 11, CategoryId = 3, TextInLanguage1 = "saai", TextInLanguage2 = "boring", SentenceInLanguage1 = "Ik vond de Filmje saai." },
                new Word {Id = 12, CategoryId = 3, TextInLanguage1 = "bedroefd", TextInLanguage2 = "sad", SentenceInLanguage1 = "Ik voel me vandaag bedroefd." },
                new Word {Id = 13, CategoryId = 3, TextInLanguage1 = "ingewikkeld", TextInLanguage2 = "complicated", SentenceInLanguage1 = "Deze situatie is heel ingewikkeld volgens mij." },
                new Word {Id = 14, CategoryId = 3, TextInLanguage1 = "enorme", TextInLanguage2 = "huge", SentenceInLanguage1 = "We hebben enorme industries hier in Nederland." },
                new Word {Id = 15, CategoryId = 3, TextInLanguage1 = "geweldig", TextInLanguage2 = "awesome", SentenceInLanguage1 = "Hij is een geweldig persoon." }
            };
        }

        public void Add(Word word)
        {
            throw new NotImplementedException();
        }

        public void Delete(Word word)
        {
            throw new NotImplementedException();
        }

        public void Update(Word word)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll()
        {
            return _wordList;
        }

        public List<Word> GetAllByCategoryId(int categoryId)
        {
            return _wordList.Where(w => w.CategoryId == categoryId).ToList();
        }

        public List<Word> GetAllById(int[] randomIdArray)
        {
            List<Word> wordListById = new List<Word> ();

            for (int i = 0; i < randomIdArray.Length; i++)
            {
                wordListById.Add(_wordList[randomIdArray[i]]);
            }

            return wordListById;
        }
    }
}
