using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Functions fnc = new Functions();
            //fnc.SendRandomNumbers(1, 100, 4);

            WordManager wordManager = new WordManager(new ExcelWordDal());

            while (true)
            {
                List<Word> wordList = wordManager.GetWords(1);

                foreach (var word in wordList)
                {
                    Console.WriteLine(word.TextInLanguage1 + " : " + word.TextInLanguage2);
                }

                Console.ReadLine();
            }
            
        }
    }

    class Functions 
    {
        public int[] SendRandomNumbers(int minValue, int maxValue, int quantityOfNumbers)
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
                Console.WriteLine(randomNumber);
            }

            return numberArray;
        }

    }

}
