using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class WordManager : IWordService
    {
        IWordDal _wordDal;
        List<Word> _wordList;

        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
            _wordList = wordDal.GetAll();
        }

        public List<Word> GetAll()
        {
            return _wordDal.GetAll();
        }

        public List<Word> GetAllByCategoryId(int categoryId)
        {
            return _wordDal.GetAllByCategoryId(categoryId);
        }

        public List<Word> GetAllById(int[] randomIdArray)
        {
            return _wordDal.GetAllById(randomIdArray);
        }

        public List<Word> GetWords(int categoryId) //If categoryId is zero, then it returns all the words.
        {
            List<Word> newWordList = new List<Word>();
            int[] randomWordIds;

            if (categoryId == 0)
            {
                int randomNumber = GetRandomNumber(1, 4);

                foreach (var word in _wordList)
                {
                    if (word.CategoryId == randomNumber)
                    {
                        newWordList.Add(word);
                    }
                }
            }
            else
            {
                foreach (var word in _wordList)
                {
                    if (word.CategoryId == categoryId)
                    {
                        newWordList.Add(word);
                    }
                }
            }

            randomWordIds = GetRandomNumbers(1, newWordList.Count(), 3);
            return new List<Word> { newWordList[randomWordIds[0]], newWordList[randomWordIds[1]], newWordList[randomWordIds[2]] };
        }


        public int GetRandomNumber(int minValue, int maxValue)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(minValue, maxValue);
            return randomNumber;
        }

        public int[] GetRandomNumbers(int minValue, int maxValue, int quantityOfNumbers)
        {
            int[] numberArray = new int[quantityOfNumbers];
            Random rnd = new Random();

            for (int i = 0; i < quantityOfNumbers; i++)
            {
                int randomNumber = rnd.Next(minValue, maxValue);

                while (numberArray.Contains(randomNumber))
                {
                    randomNumber = rnd.Next(minValue, maxValue);
                }

                numberArray[i] = randomNumber;
            }

            return numberArray;
        }

        
    }
}
