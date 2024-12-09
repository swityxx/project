using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gameGlav : Form
    {
        
        public gameGlav()
        {
            InitializeComponent();
            
            
        }
        private bool game = true;
       
        private void Vis()
        {
            panel1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            KeyPreview = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            int speed = 10;
            pictureBox1.Top += speed;
            pictureBox3.Top += speed;

            int metspeed = 7;
            meteor1.Top += metspeed;
            meteor2.Top += metspeed;
            meteor3.Top += metspeed;  
            meteor4.Top += metspeed;


            if (pictureBox1.Top > 625)
            {
                pictureBox1.Top = 0;
                pictureBox3.Top = -625;
            }
            if (meteor1.Top > 625)
            {
                meteor1.Top = -80;
                Random rand = new Random();
                meteor1.Left = rand.Next(0, 200);
            }

            else if (meteor2.Top > 625)
            {
                meteor2.Top = -120;
                Random rand = new Random();
                meteor2.Left = rand.Next(200, 400);
            }
            else if (meteor3.Top > 625)
            {
                meteor3.Top = -200;
                Random rand = new Random();
                meteor3.Left = rand.Next(400, 600);
            }
            else if (meteor4.Top > 625)
            {
                meteor4.Top = -20;
                Random rand = new Random();
                meteor4.Left = rand.Next(600, 800);
            }
            if (raketa.Bounds.IntersectsWith(meteor1.Bounds) || raketa.Bounds.IntersectsWith(meteor2.Bounds))
            {
               
                timer1.Stop();

                
                Vis();
                game = false;

            }
        }

        private void gameGlav_KeyDown(object sender, KeyEventArgs e)
        {
            if (game == true)
            {
                int speed = 10;
                if (e.KeyCode == Keys.Left && raketa.Left > 0)
                {
                    raketa.Left -= speed;

                }
                else if (e.KeyCode == Keys.Right && raketa.Right < 800)
                {
                    raketa.Left += speed;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meteor1.Top = -80;
            meteor2.Top = -120;
            meteor3.Top = -200;
            meteor4.Top = -20;
            panel1.Visible = false;
            pictureBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            game = true;
            timer1.Start();
            timer2.Start();
           
        }
        public int seconds = 0;
        public int max = 0;
        public int max2 = 0, maxmin = 0, maxsec = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            max++;
            int minute = seconds / 60;
            int second = seconds % 60;


            if (max > max2)
            {
                max2 = seconds;
                maxmin = minute;
                maxsec = second;
            }
            
            label4.Text = minute.ToString("D2") + ":" + second.ToString("D2");
            if (raketa.Bounds.IntersectsWith(meteor1.Bounds) || raketa.Bounds.IntersectsWith(meteor2.Bounds))
            {

                timer2.Stop();
                label2.Text = "Время полета: " + minute.ToString("D2") + ":" + second.ToString("D2");
                label3.Text = "Рекорд: " +maxmin.ToString("D2") + ":" + maxsec.ToString("D2");
                seconds = 0;
                minute = 0;
                second = 0;
                max = 0;
            }
                

        }
        
    }
}
