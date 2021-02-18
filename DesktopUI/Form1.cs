using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace DesktopUI
{
    public partial class Form1 : Form
    {
        WordManager wordManager = new WordManager(new ExcelWordDal());
        List<Word> wordList;
        int categoryId = 0;
        int randomNumber;
        bool isInverseMode = false;
        string path = Application.StartupPath;
        int a = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object Geter, EventArgs e)
        {
            ExecuteOneRound();
            comboBox1.Items.Add("Mixed");
            comboBox1.Items.Add("Verbs");
            comboBox1.Items.Add("Nouns");
            comboBox1.Items.Add("Adjectives");
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox2.Items.Add("NL>ENG");
            comboBox2.Items.Add("ENG>NL");
            comboBox2.SelectedItem = comboBox2.Items[0];
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ExecuteOneRound()
        {
            wordList = wordManager.GetWords(categoryId);
            randomNumber = wordManager.GetRandomNumber(1, 3);

            if (isInverseMode)
            {
                label1.Text = wordList[randomNumber].TextInLanguage2;
                button1.Text = wordList[0].TextInLanguage1;
                button2.Text = wordList[1].TextInLanguage1;
                button3.Text = wordList[2].TextInLanguage1;
            }
            else
            {
                label1.Text = wordList[randomNumber].TextInLanguage1;
                button1.Text = wordList[0].TextInLanguage2;
                button2.Text = wordList[1].TextInLanguage2;
                button3.Text = wordList[2].TextInLanguage2;
            }            
        }

        private void ClearButtonColors()
        {
            button1.Enabled = true;
            button1.BackColor = SystemColors.Control;
            button2.Enabled = true;
            button2.BackColor = SystemColors.Control;
            button3.Enabled = true;
            button3.BackColor = SystemColors.Control;
        }

        private void button1_Click(object Geter, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            if (isInverseMode)
            {
                if (button1.Text == wordList[randomNumber].TextInLanguage1)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Red;

                    if (button2.Text == wordList[randomNumber].TextInLanguage1)
                    {
                        button2.BackColor = Color.Green;
                    }
                    else
                    {
                        button3.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                if (button1.Text == wordList[randomNumber].TextInLanguage2)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Red;

                    if (button2.Text == wordList[randomNumber].TextInLanguage2)
                    {
                        button2.BackColor = Color.Green;
                    }
                    else
                    {
                        button3.BackColor = Color.Green;
                    }
                }
            }

            button4.Focus();
        }

        private void button2_Click(object Geter, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            if (isInverseMode)
            {
                if (button2.Text == wordList[randomNumber].TextInLanguage1)
                {
                    button2.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;

                    if (button1.Text == wordList[randomNumber].TextInLanguage1)
                    {
                        button1.BackColor = Color.Green;
                    }
                    else
                    {
                        button3.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                if (button2.Text == wordList[randomNumber].TextInLanguage2)
                {
                    button2.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;

                    if (button1.Text == wordList[randomNumber].TextInLanguage2)
                    {
                        button1.BackColor = Color.Green;
                    }
                    else
                    {
                        button3.BackColor = Color.Green;
                    }
                }
            }

            button4.Focus();
        }

        private void button3_Click(object Geter, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            if (isInverseMode)
            {
                if (button3.Text == wordList[randomNumber].TextInLanguage1)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;

                    if (button2.Text == wordList[randomNumber].TextInLanguage1)
                    {
                        button2.BackColor = Color.Green;
                    }
                    else
                    {
                        button1.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                if (button3.Text == wordList[randomNumber].TextInLanguage2)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;

                    if (button2.Text == wordList[randomNumber].TextInLanguage2)
                    {
                        button2.BackColor = Color.Green;
                    }
                    else
                    {
                        button1.BackColor = Color.Green;
                    }
                }
            }

            button4.Focus();
        }

        private void button4_Click(object Geter, EventArgs e)
        {
            ClearButtonColors();
            ExecuteOneRound();
        }

        private void comboBox1_SelectedIndexChanged(object Geter, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    categoryId = 0;
                    break;
                case 1:
                    categoryId = 1;
                    break;
                case 2:
                    categoryId = 2;
                    break;
                case 3:
                    categoryId = 3;
                    break;
                default:
                    categoryId = 0;
                    break;
            }

            ClearButtonColors();
            ExecuteOneRound();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    isInverseMode = false;
                    break;
                case 1:
                    isInverseMode = true;
                    break;
                default:
                    isInverseMode = false;
                    break;
            }

            ClearButtonColors();
            ExecuteOneRound();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                ExecuteOneRound();
            }
        }
    }
}
