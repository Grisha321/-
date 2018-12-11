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

namespace Шифр_Цезаря
{
    public partial class ReadMe : Form
    {
        public ReadMe()
        {
            InitializeComponent();
        }

        private void ReadMe_Load(object sender, EventArgs e)
        {
            tbReadMe.Text = File.ReadAllText(@"..\..\..\ReadMe.txt", Encoding.GetEncoding(1251));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
