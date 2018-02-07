using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Rtf2PlainConverter
{
    public partial class pnlRtf2TextConverter : MetroUserControl
    {
        public pnlRtf2TextConverter()
        {
            InitializeComponent();
        }
        private RichTextBox rtfBox = new RichTextBox();
        private void btnConvert_Click(object sender, EventArgs e)
        {
            rtfBox.Clear();
            if (IsRtf(txtSource.Text))
            {
                txtDest.Text = rtfBox.Text;
            }
            else
            {
                rtfBox.Text = txtSource.Text;
                txtDest.Text = rtfBox.Rtf;
            }
        }

        public bool IsRtf(string text)
        {
            if (text.TrimStart().IndexOf(@"{\rtf1", StringComparison.Ordinal)>=0)
            {
                if (IsValidRtf(text))
                    return true;
            }

            return false;
        }

        private bool IsValidRtf(string text)
        {
            try
            {
                rtfBox.Rtf = text;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
    }
}
