using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QR.QRGenerator QG = new QR.QRGenerator();
            var MyData = QG.CreateQrCode(textBox1.Text, QR.QRGenerator.ECCLevel.H);
            var code = new QR.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

        }
    }
}
