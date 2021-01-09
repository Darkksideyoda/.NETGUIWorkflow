/*


BAHTİYAR KARAKOÇ 
181312018



*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace _7segsim
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int i = 0;
        bool isik = true;
        bool isik2 = true;
        bool isik3 = true;
        bool isik4 = true;
        bool isik5 = true;
        bool isik6 = true;
        bool isik7 = true;
        bool full = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        public void MetroButton1_Click(object sender, EventArgs e)
        {

            if (i == 0) {
                timer1.Interval = 50;
                timer1.Enabled = true;
               // metroRadioButton1.PerformClick();
            } i++;

           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int i=0;

            
           
                if (isik)
                {
                    button1.BackColor = Color.LimeGreen;
                    button1.ForeColor = Color.LimeGreen;
                    label9.ForeColor = Color.LimeGreen;
                    label12.ForeColor = Color.LimeGreen;
                    label12.Text = "1";
                    isik = false;

                
                }

            
                else
                {
                
                button1.BackColor = Color.FromArgb(17, 17, 17);
                    button1.ForeColor = Color.FromArgb(153, 180, 209);
                    label9.ForeColor = Color.FromArgb(153, 180, 209);
                    label12.ForeColor = Color.FromArgb(153, 180, 209);
                    label12.Text = "0";
                    isik = true;
                timer2.Interval = 50;
                timer2.Enabled = true;
                isik2 = false;

                timer1.Stop();
                
                }
           
                

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (isik2 == false)
            {



                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.LimeGreen;
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";
                isik2 = true;


            }
            else
            {
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                isik = true;
                timer3.Interval = 50;
                timer3.Enabled = true;
                isik3 = false;
                timer2.Stop();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (isik3 == false)
            {

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.LimeGreen;
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";
                isik3 = true;


            }
            else
            {
                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                isik = true;
                timer4.Interval = 50;
                timer4.Enabled = true;
                isik4 = false;
                timer3.Stop();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (isik4 == false)
            {

                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.LimeGreen;
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";
                isik4 = true;


            }
            else
            {
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                isik = true;
                timer5.Interval = 50;
                timer5.Enabled = true;
                isik5 = false;
                timer4.Stop();
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (isik5 == false)
            {

                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.LimeGreen;
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";
                isik5 = true;


            }
            else
            {
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                isik = true;
                timer6.Interval = 50;
                timer6.Enabled = true;
                isik6 = false;
                timer5.Stop();
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            if (isik6 == false)
            {

                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.LimeGreen;
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";
                isik6 = true;


            }
            else
            {
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                isik = true;
                timer7.Interval = 50;
                timer7.Enabled = true;
                isik7 = false;
                timer6.Stop();
            }
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
            if (isik7 == false)
            {

                button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.LimeGreen;
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";
                isik7 = true;


            }
            else
            {
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                isik = true;
                timer8.Interval = 500;
                timer8.Enabled = true;
                full = false;
                timer7.Stop();
            }
        }

        private void Timer8_Tick(object sender, EventArgs e)
        {
            if (full == false)
            {

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.LimeGreen;
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";
                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.LimeGreen;
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";
                isik3 = true;
                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.LimeGreen;
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";

                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.LimeGreen;
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";
                button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.LimeGreen;
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";

                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.LimeGreen;
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";

                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.LimeGreen;
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";
                button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.LimeGreen;
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";
                full = true;


            }
            else
            {

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                isik = true;
               
                full = false;
                timer8.Stop();
                
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            i = 0;
        }

        private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(i != 0)
            {
                

                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";


                /////////////////////////////////////
                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";

                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.FromArgb(17, 17, 17);
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";


                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


                /*
                 * 
                 *
                 *
                 * 
                 * 
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.LimeGreen;
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";
             

            7

                 **/


                





            }

        }

        private void MetroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {


               

                ////////////////////



                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                ////////////////////////////////////////////////
                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                



            }
        }

        private void MetroRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {
               

                ////////////////////
                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                /////////////////////////////////////////////////////

                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";


                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";



                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";


                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.FromArgb(17, 17, 17);
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";

                button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";


                

            }
        }

        private void MetroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {
               

                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";





                ////////////////
                ///
                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";

                button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";


                

            }
        }

        private void MetroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {


            if (i != 0)
            {
                

                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";





                ////////////////
                ///

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";

                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


                 
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";



               
            }
        }

        private void MetroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (i != 0)
            {
                

                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";





                ////////////////
                ///


                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";


                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";



                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


                
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";



                



            }
            }

        private void MetroRadioButton7_CheckedChanged(object sender, EventArgs e)
        {

            if (i != 0)
            {

               
                ////////////////////


                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";





                ////////////////


               


                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";


                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";

                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.FromArgb(17, 17, 17);
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";


                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


               
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";

            }
        }

        private void MetroRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {



                
                ////////////////////
                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";





                ////////////////
                ///

                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";

                


            }
            }

        private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {
               

                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";


                /////////////////////////////////////
                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";

                button5.BackColor = Color.LimeGreen;
                button5.ForeColor = Color.FromArgb(17, 17, 17);
                label5.ForeColor = Color.LimeGreen;
                label10.ForeColor = Color.LimeGreen;
                label10.Text = "1";


                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


                
                 
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";
             

           
            }
        }

        private void MetroRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (i != 0)
            {


               
                ////////////////////

                button6.BackColor = Color.FromArgb(17, 17, 17);
                button6.ForeColor = Color.FromArgb(153, 180, 209);
                label2.ForeColor = Color.FromArgb(153, 180, 209);
                label4.ForeColor = Color.FromArgb(153, 180, 209);
                label4.Text = "0";
                button4.BackColor = Color.FromArgb(17, 17, 17);
                button4.ForeColor = Color.FromArgb(153, 180, 209);
                label1.ForeColor = Color.FromArgb(153, 180, 209);
                label3.ForeColor = Color.FromArgb(153, 180, 209);
                label3.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";
                button1.BackColor = Color.FromArgb(17, 17, 17);
                button1.ForeColor = Color.FromArgb(153, 180, 209);
                label9.ForeColor = Color.FromArgb(153, 180, 209);
                label12.ForeColor = Color.FromArgb(153, 180, 209);
                label12.Text = "0";
                button3.BackColor = Color.FromArgb(17, 17, 17);
                button3.ForeColor = Color.FromArgb(153, 180, 209);
                label6.ForeColor = Color.FromArgb(153, 180, 209);
                label13.ForeColor = Color.FromArgb(153, 180, 209);
                label13.Text = "0";
                button5.BackColor = Color.FromArgb(17, 17, 17);
                button5.ForeColor = Color.FromArgb(153, 180, 209);
                label5.ForeColor = Color.FromArgb(153, 180, 209);
                label10.ForeColor = Color.FromArgb(153, 180, 209);
                label10.Text = "0";
                button8.BackColor = Color.FromArgb(17, 17, 17);
                button8.ForeColor = Color.FromArgb(153, 180, 209);
                label7.ForeColor = Color.FromArgb(153, 180, 209);
                label11.ForeColor = Color.FromArgb(153, 180, 209);
                label11.Text = "0";
                button2.BackColor = Color.FromArgb(17, 17, 17);
                button2.ForeColor = Color.FromArgb(153, 180, 209);
                label8.ForeColor = Color.FromArgb(153, 180, 209);
                label14.ForeColor = Color.FromArgb(153, 180, 209);
                label14.Text = "0";


                /////////////////////////////////////
                button1.BackColor = Color.LimeGreen;
                button1.ForeColor = Color.FromArgb(17, 17, 17);
                label9.ForeColor = Color.LimeGreen;
                label12.ForeColor = Color.LimeGreen;
                label12.Text = "1";

                button4.BackColor = Color.LimeGreen;
                button4.ForeColor = Color.FromArgb(17, 17, 17);
                label1.ForeColor = Color.LimeGreen;
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "1";

                button6.BackColor = Color.LimeGreen;
                button6.ForeColor = Color.FromArgb(17, 17, 17);
                label2.ForeColor = Color.LimeGreen;
                label4.ForeColor = Color.LimeGreen;
                label4.Text = "1";


                button8.BackColor = Color.LimeGreen;
                button8.ForeColor = Color.FromArgb(17, 17, 17);
                label7.ForeColor = Color.LimeGreen;
                label11.ForeColor = Color.LimeGreen;
                label11.Text = "1";

                button3.BackColor = Color.LimeGreen;
                button3.ForeColor = Color.FromArgb(17, 17, 17);
                label6.ForeColor = Color.LimeGreen;
                label13.ForeColor = Color.LimeGreen;
                label13.Text = "1";


               
               button2.BackColor = Color.LimeGreen;
                button2.ForeColor = Color.FromArgb(17, 17, 17);
                label8.ForeColor = Color.LimeGreen;
                label14.ForeColor = Color.LimeGreen;
                label14.Text = "1";
             

            
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label30_Click(object sender, EventArgs e)
        {

        }

        private void Label29_Click(object sender, EventArgs e)
        {

        }
    }
    }

