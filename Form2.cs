using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int v=0,i=5,j=5,s=45,n;
        int[] val = { 0, 4, 4, 4, 5, 3, 4, 4, 4, 4 };
        bool ok;
        //ok true-valoare corecta;false-valoare gresita
        //j este nr de indicii
        //s este nr de casute necompletate
        //i este nr de vieti
        //v este cifra curenta selectata
        //n este nr corect din casuta

        void verificare_valoare()
        {
            if (v == n || v == 10)
            {
                ok = true;
                s--;
                val[n]++;
                if(val[n]==9)
                {
                    switch (n)
                    {
                        case 1:button90.Visible = false;break;
                        case 2:button82.Visible = false;break;
                        case 3:button83.Visible = false;break;
                        case 4:button84.Visible = false;break;
                        case 5:button85.Visible = false;break;
                        case 6:button86.Visible = false;break;
                        case 7:button87.Visible = false;break;
                        case 8:button88.Visible = false;break;
                        case 9:button89.Visible = false;break;
                    }
                    reset_val();
                    v = 0;
                }
                if (v == 10)
                {
                    if (j != 0)
                    {
                        j--;
                        label3.Text = "Numar indicii: " + j;
                    }
                    else
                    {
                        MessageBox.Show("Ai ramas fara indicii!");
                        ok = false;
                    }
                }
            }
            else
            if (v == 0)
                MessageBox.Show("Trebuie sa alegi o cifra!");
            else
            {
                ok = false;
                i--;
                if (i != 0)
                {
                    MessageBox.Show("Gresit!");
                    label2.Text = "Numar vieti: " + i;
                }
                else
                {
                    MessageBox.Show("Ai pierdut!");
                    Application.Exit();
                }    
            }
            if (s == 0)
            {
                MessageBox.Show("Ai castigat!");
                this.Hide();
                Form1.instance.Show();
            }
        }

        void val_selectata()
        {
            switch(v)
            {
                case 0:break;
                case 1: button90.BackColor = Color.Gold; break;
                case 2: button82.BackColor = Color.Gold; break;
                case 3: button83.BackColor = Color.Gold; break;
                case 4: button84.BackColor = Color.Gold; break;
                case 5: button85.BackColor = Color.Gold; break;
                case 6: button86.BackColor = Color.Gold; break;
                case 7: button87.BackColor = Color.Gold; break;
                case 8: button88.BackColor = Color.Gold; break;
                case 9: button89.BackColor = Color.Gold; break;
                case 10:button93.BackColor = Color.Gold;break;
            }
        }

        void reset_val()
        {
            switch(v)
            {
                case 0: break;
                case 1: button90.BackColor = Color.MediumSeaGreen; break;
                case 2: button82.BackColor = Color.MediumSeaGreen; break;
                case 3: button83.BackColor = Color.MediumSeaGreen; break;
                case 4: button84.BackColor = Color.MediumSeaGreen; break;
                case 5: button85.BackColor = Color.MediumSeaGreen; break;
                case 6: button86.BackColor = Color.MediumSeaGreen; break;
                case 7: button87.BackColor = Color.MediumSeaGreen; break;
                case 8: button88.BackColor = Color.MediumSeaGreen; break;
                case 9: button89.BackColor = Color.MediumSeaGreen; break;
                case 10:button93.BackColor = Color.MediumSeaGreen; break;
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button91_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.instance.Show();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (j != 0)
            {
                reset_val();
                v = 10;
                val_selectata();
            }
            else
               MessageBox.Show("Ai ramas fara indicii!");
            //butonul de indiciu
        }

        private void button90_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 1;
            val_selectata();
            //initializeaza valoarea care urmeaza pusa si o scrie intr-un label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button1.Text = n.ToString();
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 2;
            val_selectata();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 5;
            val_selectata();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 6;
            val_selectata();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 7;
            val_selectata();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 8;
            val_selectata();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 9;
            val_selectata();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button35_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button45_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button53_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button51_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button47_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button46_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button61_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button72_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button80_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button79_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button59_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button68_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button77_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button76_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button57_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button55_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button65_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button16.Text = n.ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button26.Text = n.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button4.Text = n.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button15.Text = n.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button13.Text = n.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button24.Text = n.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button22.Text = n.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button7.Text = n.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button12.Text = n.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button11.Text = n.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button20.Text = n.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button19.Text = n.ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button34.Text = n.ToString();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button44.Text = n.ToString();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button43.Text = n.ToString();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (button54.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button54.Text = n.ToString();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (button52.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button52.Text = n.ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button33.Text = n.ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button32.Text = n.ToString();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button41.Text = n.ToString();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (button50.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button50.Text = n.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button49.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button49.Text = n.ToString();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button30.Text = n.ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button28.Text = n.ToString();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button39.Text = n.ToString();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button38.Text = n.ToString();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button48.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button48.Text = n.ToString();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button63.Text = n.ToString();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (button62.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button62.Text = n.ToString();
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (button71.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button71.Text = n.ToString();
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (button70.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button70.Text = n.ToString();
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (button81.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button81.Text = n.ToString();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (button60.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button60.Text = n.ToString();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (button58.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button58.Text = n.ToString();
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (button69.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button69.Text = n.ToString();
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (button67.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button67.Text = n.ToString();
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button78.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button78.Text = n.ToString();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (button56.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button56.Text = n.ToString();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (button66.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button66.Text = n.ToString();
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (button75.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button75.Text = n.ToString();
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (button74.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button74.Text = n.ToString();
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (button73.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button73.Text = n.ToString();
            }
        }

        //buton cu functie
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button3.Text = n.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button2.Text = n.ToString();
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 3;
            val_selectata();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 4;
            val_selectata();
        }
    }
}


