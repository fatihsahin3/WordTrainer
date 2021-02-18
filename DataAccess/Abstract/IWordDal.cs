using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IWordDal
    {
        List<Word> GetAll();
        List<Word> GetAllById(int[] randomIdArray);
        List<Word> GetAllByCategoryId(int categoryId);
        void Add(Word word);
        void Delete(Word word);
        void Update(Word word);
    }
}
