using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWordService
    {
        List<Word> GetAll();
        List<Word> GetAllByCategoryId(int categoryId);
        List<Word> GetAllById(int[] randomIdArray);
    }
}
