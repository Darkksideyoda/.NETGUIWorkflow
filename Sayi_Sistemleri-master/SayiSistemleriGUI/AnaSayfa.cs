using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiSistemleriGUI
{
    public partial class AnaSayfa : MetroFramework.Forms.MetroForm
    {
    
        public AnaSayfa()
        {

            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

            
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bu Özellik Yapım Aşamasındadır\nSadece 2 İnput Almaktadır");
            MessageBox.Show("Başlangıç Değerleri Default AND Kapısıdır.");
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
