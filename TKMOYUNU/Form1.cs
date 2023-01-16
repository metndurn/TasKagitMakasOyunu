using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKMOYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor = 0;
        int bot = 0;
        private void btnTAS_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int sayi;
            sayi = random.Next(1, 4);
            if (sayi==1)
            {
                lblgoster.Text = "Beraberlik";
                button6.BackColor = Color.Yellow;
            }
            else if(sayi==2)
            {
                bot++;
                lblbot.Text=bot.ToString();
                lblgoster.Text = "Kaybettiniz";
                button5.BackColor = Color.Red;
            }
            else if(sayi==3)
            {
                skor++;
                lblskor.Text=skor.ToString();
                lblgoster.Text = "Kazandiniz";
                button4.BackColor = Color.Green;
            }
        }

        private void btnKAGIT_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int sayi;
            sayi = random.Next(1, 4);
            if (sayi==1)
            {
                skor++;
                lblskor.Text=skor.ToString();
                lblgoster.Text = "Kazandiniz";
                button6.BackColor = Color.Yellow;
            }
            else if(sayi==2)
            {
                lblgoster.Text = "Beraberlik";
                button5.BackColor = Color.Red;
            }
            else if (sayi==3)
            {
                bot++;
                lblbot.Text=bot.ToString();
                lblgoster.Text = "Kaybettiniz";
                button4.BackColor = Color.Green;
            }
        }

        private void btnMAKAS_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int sayi;
            sayi = random.Next(1, 4);
            if (sayi==1)
            {
                bot++;
                lblbot.Text=bot.ToString();
                lblgoster.Text = "Kaybettiniz";
                button6.BackColor = Color.Red;
            }
            else if (sayi==2)
            {
                skor++;
                lblskor.Text=skor.ToString();
                lblgoster.Text = "Kazandiniz";
                button5.BackColor = Color.Green;
            }
            else if (sayi==3)
            {
                lblgoster.Text = "Beraberlik";
                button4.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bot == 3)
            {
                lblgoster.Text = "Rakibiniz Kazandi";
                btnTAS.Enabled = false;
                btnKAGIT.Enabled = false;
                btnMAKAS.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (skor == 3)
            {
                lblgoster.Text = "Siz Kazandiniz";
                btnTAS.Enabled = false;
                btnKAGIT.Enabled = false;
                btnMAKAS.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
    }
}
