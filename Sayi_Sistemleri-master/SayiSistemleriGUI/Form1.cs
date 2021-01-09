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
    

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
           
            InitializeComponent();

            
            //Convert.ToInt32(this.metroTextBox1.Text);

            // Convert.ToInt32(this.metroTextBox1.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sistemler1 = { "BINARY","OCTAL","DECIMAL","HEXADECIMAL"};
            string[] sistemler2 = { "BINARY", "OCTAL", "DECIMAL", "HEXADECIMAL" };
            metroComboBox1.Items.AddRange(sistemler1);
            metroComboBox2.Items.AddRange(sistemler2);

            

        }
        static int octalToDecimal(int n)
        {
            int num = n;
            int dec_value = 0;

            int b_ase = 1;

            int temp = num;
            while (temp > 0)
            {

                
                int last_digit = temp % 10;
                temp = temp / 10;

                
                dec_value += last_digit
                                  * b_ase;

                b_ase = b_ase * 8;
            }
            return dec_value;
        }

        static int hexadecimalToDecimal(String hexVal)
        {
            int len = hexVal.Length;

            
            int base1 = 1;

            int dec_val = 0;

            
            for (int i = len - 1; i >= 0; i--)
            {
              
                if (hexVal[i] >= '0' &&
                    hexVal[i] <= '9')
                {
                    dec_val += (hexVal[i] - 48) * base1;

                    
                    base1 = base1 * 16;
                }

                
                else if (hexVal[i] >= 'A' &&
                         hexVal[i] <= 'F')
                {
                    dec_val += (hexVal[i] - 55) * base1;

                    
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }

        static int bintodec(int r1)
        {

            int i = 1, temp = 0, temp2 = 0;


            while (r1 > 0)
            {
                temp = r1 % 10;
                r1 /= 10;
                temp2 += i * temp;
                i *= 2;
            }

            return temp2;
        }

        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            
            int sc1, sc2, inp = 0, islem;
            int i = 1, isl, temp = 0, temp2 = 0, brm = 0,shw;
            int[] ters = new int[7];
            long binary_number, hexadecimal_number = 0, j = 1, remainder,temp3 = 0;

            string HEXER;
            int n1, n, p = 1;
            int dec = 0, z, d;
            int ocno = 0;







            

           int.TryParse(metroTextBox1.Text, out inp);
            label1.ForeColor = Color.Green;
            

            if (metroComboBox1.Text == "BINARY" && metroComboBox2.Text == "BINARY")
            {
                metroTextBox2.Clear();

                metroTextBox2.Text = metroTextBox1.Text;

                //metroTextBox2.Text = octaltodec(5).ToString();
            }

           

            if (metroComboBox1.Text == "BINARY" && metroComboBox2.Text == "OCTAL")
            {
                metroTextBox2.Clear();
                for (z = inp; z > 0; z = z / 10)
                {
                    d = z % 10;
                    if (i == 1)
                        p = p * 1;
                    else
                        p = p * 2;

                    dec = dec + (d * p);
                    i++;
                }
                
                /*--------------------------------------------*/
                i = 1;

                for (z = dec; z > 0; z = z / 8)
                {
                    ocno = ocno + (z % 8) * i;
                    i = i * 10;
                    inp = inp / 8;
                }

                //metroTextBox2.Text = temp2.ToString("c").Remove(0, 1);
                metroTextBox2.Text += ocno; 
               
            }












            if (metroComboBox1.Text == "BINARY" && metroComboBox2.Text == "DECIMAL")
            {
                metroTextBox2.Clear();
                    while (inp > 0){
                    temp = inp % 10;
                    inp /= 10;
                    temp2 += i * temp;
                    i *= 2;
                        }

                //metroTextBox2.Text = temp2.ToString("c").Remove(0, 1);
                metroTextBox2.Text += temp2;

            }
            if (metroComboBox1.Text == "BINARY" && metroComboBox2.Text == "HEXADECIMAL")
            {
                metroTextBox2.Clear();

                while (inp > 0)
                {
                    temp = inp % 10;
                    inp /= 10;
                    temp2 += i * temp;
                    i *= 2;
                }
                
                metroTextBox2.Text += Convert.ToString(temp2, 16); 

            }
            /*-----------------------------------------------DECIMAL-----------------------------------------*/
            if (metroComboBox1.Text == "DECIMAL" && metroComboBox2.Text == "BINARY")
            {
                metroTextBox2.Clear();

                do
                {
                    isl = inp / 2;
                    temp = inp % 2;
                    temp2 = isl;
                    inp = isl;
                    ters[brm] = temp;
                    brm++;
                    //printf("\nDeger: %d , %d\n",temp,isl);

                } while (isl != 0);

                for (int k = ters.Length - 1; k >= 0; k--)
                {
                    //ters çevirme işlemi yapıyoruz ve textbox2'ye değerleri yazdırıyoruz
                    //string ters çevirme işlemi ile neredeyse aynı
                    metroTextBox2.Text += ters[k];
                    
                }

            }

           if(metroComboBox1.Text == "DECIMAL" && metroComboBox2.Text == "OCTAL")
            {
                metroTextBox2.Clear();


                isl = inp;
                while (isl != 0)
                {
                    ters[i++] = isl % 8;
                    isl = isl / 8;
                }
                
                for (int m = i - 1; m > 0; m--)
                {

                    // metroTextBox2.Text = ters[m].ToString("c").Remove(0, 1);

                    metroTextBox2.Text += ters[m];
                }
            }

            if (metroComboBox1.Text == "DECIMAL" && metroComboBox2.Text == "DECIMAL")
            {
                metroTextBox2.Clear();

                metroTextBox2.Text = metroTextBox1.Text;
            }

            if (metroComboBox1.Text == "DECIMAL" && metroComboBox2.Text == "HEXADECIMAL")
            {
                metroTextBox2.Clear();

                metroTextBox2.Text = Convert.ToString(inp, 16);
            }




            /*---------------------------------------------OCTAL-------------------------------------------*/
            if (metroComboBox1.Text == "OCTAL" && metroComboBox2.Text == "OCTAL")
            {
                metroTextBox2.Clear();

                metroTextBox2.Text = metroTextBox1.Text;
            }

            if (metroComboBox1.Text == "OCTAL" && metroComboBox2.Text == "BINARY")
            {

                metroTextBox2.Clear();
                metroTextBox2.Text = Convert.ToString(octalToDecimal(inp), 2);
            }

            if (metroComboBox1.Text == "OCTAL" && metroComboBox2.Text == "DECIMAL")
            {

                metroTextBox2.Clear();
                metroTextBox2.Text = octalToDecimal(inp).ToString();
            }

            if (metroComboBox1.Text == "OCTAL" && metroComboBox2.Text == "HEXADECIMAL")
            {

                metroTextBox2.Clear();
                metroTextBox2.Text = Convert.ToString(octalToDecimal(inp), 16);


            }



            /*---------------------------HEXADECIMAL---------------------------------------*/


            if (metroComboBox1.Text == "HEXADECIMAL" && metroComboBox2.Text == "HEXADECIMAL")
            {

                metroTextBox2.Clear();

                metroTextBox2.Text = metroTextBox1.Text;
            }


            if (metroComboBox1.Text == "HEXADECIMAL" && metroComboBox2.Text == "BINARY")
            {

                metroTextBox2.Clear();
                HEXER = inp.ToString();
                metroTextBox2.Text = Convert.ToString(hexadecimalToDecimal(HEXER), 2);

            }

            if (metroComboBox1.Text == "HEXADECIMAL" && metroComboBox2.Text == "DECIMAL")
            {

                metroTextBox2.Clear();

               HEXER = inp.ToString();

                metroTextBox2.Text = hexadecimalToDecimal(HEXER).ToString();

            }

            if (metroComboBox1.Text == "HEXADECIMAL" && metroComboBox2.Text == "OCTAL")
            {

                metroTextBox2.Clear();

                HEXER = inp.ToString();
                metroTextBox2.Text = Convert.ToString(hexadecimalToDecimal(HEXER), 8);

            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }


  
}

