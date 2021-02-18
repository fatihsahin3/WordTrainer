using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataAccess.Concrete
{
    public class ExcelWordDal : IWordDal
    {
        List<Word> wordList;
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;

        public ExcelWordDal()
        {
            InitializeExcel();
        }

        public void Add(Word word)
        {
            throw new NotImplementedException();
        }

        public void Delete(Word word)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll()
        {
            return GetAllByCategoryId(0);
        }

        public List<Word> GetAllByCategoryId(int categoryId)
        {
            wordList = new List<Word>();
            int rowCount = xlRange.Rows.Count;
            int columCount = xlRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                Word word = new Word();

                if ((Convert.ToInt16(xlRange.Cells[i, 1].Value2) == categoryId) || categoryId == 0)
                {
                    for (int j = 1; j <= columCount; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                word.Id = j;
                                word.CategoryId = Convert.ToInt16(xlRange.Cells[i, j].Value2 == null ? "1" : xlRange.Cells[i, j].Value2);
                                break;
                            case 2:
                                word.TextInLanguage1 = Convert.ToString(xlRange.Cells[i, j].Value2 == null ? "" : xlRange.Cells[i, j].Value2);
                                break;
                            case 3:
                                word.TextInLanguage2 = Convert.ToString(xlRange.Cells[i, j].Value2 == null ? "" : xlRange.Cells[i, j].Value2);
                                break;
                            case 4:
                                word.SentenceInLanguage1 = Convert.ToString(xlRange.Cells[i, j].Value2 == null ? "" : xlRange.Cells[i, j].Value2);
                                break;
                            case 5:
                                word.SentenceInLanguage2 = Convert.ToString(xlRange.Cells[i, j].Value2 == null ? "" : xlRange.Cells[i, j].Value2);
                                break;
                            default:
                                break;
                        }

                    }

                    wordList.Add(word);
                }

            }

            xlWorkbook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);

            return wordList;
        }

        public List<Word> GetAllById(int[] randomIdArray)
        {
            throw new NotImplementedException();
        }

        public void Update(Word word)
        {
            throw new NotImplementedException();
        }

        public void InitializeExcel()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "WordTrainer.xls";
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(path);
            //xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\fatih\OneDrive\Desktop\WordTrainer.xls");
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;
        }

    }
}