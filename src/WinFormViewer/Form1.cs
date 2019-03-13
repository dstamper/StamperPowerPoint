using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        private void bodyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                BoldText();
            }
        }

        private void BoldText()
        {
            Font currentFont = bodyTextBox.SelectionFont;
            FontStyle newFontStyle;
            if (bodyTextBox.SelectionFont.Bold == true)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Bold;
            }

            bodyTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }


    }
}
