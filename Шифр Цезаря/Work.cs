using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;

namespace Шифр_Цезаря
{
    public partial class fWork : Form
    {
       static char[] alphabetUpper = new char[33] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
                'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        static char[] alphabetLower = new char[33] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у',
                'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public fWork()
        {
            InitializeComponent();
            cbKey.Text = "1";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadText_Click(object sender, EventArgs e) //пока только для txt файлов
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    tbOriginalText.Text = sr.ReadToEnd();
                    sr.Close();
                }
                if (openFileDialog1.FilterIndex==2)
                {
                    Document document = new Aspose.Words.Document(openFileDialog1.FileName);
                    tbOriginalText.Text = document.GetText();
                }
            }
        }

        private void btnStepBack_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(cbKey.Text);
            string result="";
            for (int i = 0; i < tbOriginalText.Text.Length; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    if (tbOriginalText.Text[i].CompareTo(alphabetUpper[j]) == 0)
                    {
                        if (j < key)
                        {
                            result += alphabetUpper[33+j-key];
                        }
                       
                        else
                        {
                            result += alphabetUpper[j-key];
                        }
                    }
                    if (tbOriginalText.Text[i].CompareTo(alphabetLower[j]) == 0)
                    {
                        if (j < key)
                        {
                            result += alphabetLower[33 + j - key];
                        }

                        else
                        {
                            result += alphabetLower[j - key];
                        }
                    }
                }
                if (i > result.Length)
                {
                    result += tbOriginalText.Text[i];
                }
            }
            tbResultText.Text = result;
        }

        private void btnStepUp_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(cbKey.Text);
            string result = "";
            for (int i = 0; i < tbOriginalText.Text.Length; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    if (tbOriginalText.Text[i].CompareTo(alphabetUpper[j])==0) 
                    {
                        if (32<j+key)
                        {
                            result += alphabetUpper[-33+j + key];
                        }

                        else
                        {
                            result += alphabetUpper[j + key];
                        }
                    }
                    if (tbOriginalText.Text[i].CompareTo(alphabetLower[j]) == 0)
                    {
                        if (32 < j + key)
                        {
                            result += alphabetLower[-33 + j + key];
                        }

                        else
                        {
                            result += alphabetLower[j + key];
                        }
                    }
                }
                if (i > result.Length)
                {
                    result +=tbOriginalText.Text[i];
                }
            }
            tbResultText.Text = result;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex==1)
                {
                    File.WriteAllText(saveFileDialog1.FileName, tbResultText.Text);
                }
                if (saveFileDialog1.FilterIndex==2)
                {
                    Document document = new Aspose.Words.Document(saveFileDialog1.FileName);
                    DocumentBuilder db = new DocumentBuilder(document);
                    db.Write(tbResultText.Text);
                    document.Save(saveFileDialog1.FileName, Aspose.Words.SaveFormat.Docx);
                }
            }
        }
    }
}

