
using Base64ConverterApp; 
using MetroFramework.Forms;
using PingerTest;
using Rtf2PlainConverter;
using System; 
using System.Windows.Forms;

namespace UtilityBelt
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tilePingTest_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var pnlPinger = new pnlPinger();
            pnlPinger.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(pnlPinger); 

        }

        private void tileBase64Converter_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var pnlBase64Converter = new pnlBase64Converter();
            pnlBase64Converter.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(new pnlBase64Converter()); 
        }

        private void btnRtf2Text_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var pnlRtf2TextConverter = new pnlRtf2TextConverter();
            pnlRtf2TextConverter.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(pnlRtf2TextConverter); 
        } 
    }
}
