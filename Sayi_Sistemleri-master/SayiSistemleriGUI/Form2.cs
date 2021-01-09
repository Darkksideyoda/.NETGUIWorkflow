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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] kapilar = { "AND", "OR", "NAND", "NOR", "NOT", "EOR", "ENOR" };
            
            metroComboBox1.Items.AddRange(kapilar);
        }


        void str_atama()
        {
            string[] A = { "1", "1", "0", "0" };
            string[] B = { "1", "0", "1", "0" };
            label12.Text = A[0];
            label13.Text = A[1];
            label14.Text = A[2];
            label15.Text = A[3];
            label19.Text = B[0];
            label18.Text = B[1];
            label17.Text = B[2];
            label16.Text = B[3];

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            label5.Text = metroTextBox1.Text;
            label6.Text = metroTextBox2.Text;
            label7.Text = metroTextBox3.Text;
            string[] AND = { "1", "0", "0", "0" };

            str_atama();



            ///////////////////////////////////
            ///


            if (metroComboBox1.Text == "AND")//BU KOD YAPIM ASAMASINDA OLDUGUNDAN STRING IFADELER INT TIPINE DONUSTURULMEDEN YAPILMISTIR UPDATE ILE DUZELECEK.
                //VE DINAMIKLIK KAZANACAKTIR
            {
                label23.Text = AND[0];
                label22.Text = AND[1];
                label21.Text = AND[2];
                label20.Text = AND[3];


            }
            /*
            if (metroComboBox1.Text == "OR")
            {



            }
            if (metroComboBox1.Text == "XOR")
            {



            }
            if (metroComboBox1.Text == "NOT")
            {



            }
            if (metroComboBox1.Text == "NOR")
            {



            }
            */


        }
    }
}
