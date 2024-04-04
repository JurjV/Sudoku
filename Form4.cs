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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int v = 0, i = 1, j = 2, s = 62, n;
        //            0  1  2  3  4  5  6  7  8  9
        int[] val = { 0, 2, 2, 2, 3, 2, 2, 2, 3, 1 };
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
                if (val[n] == 9)
                {
                    switch (n)
                    {
                        case 1: button90.Visible = false; break;
                        case 2: button82.Visible = false; break;
                        case 3: button83.Visible = false; break;
                        case 4: button84.Visible = false; break;
                        case 5: button85.Visible = false; break;
                        case 6: button86.Visible = false; break;
                        case 7: button87.Visible = false; break;
                        case 8: button88.Visible = false; break;
                        case 9: button89.Visible = false; break;
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
            switch (v)
            {
                case 0: break;
                case 1: button90.BackColor = Color.Gold; break;
                case 2: button82.BackColor = Color.Gold; break;
                case 3: button83.BackColor = Color.Gold; break;
                case 4: button84.BackColor = Color.Gold; break;
                case 5: button85.BackColor = Color.Gold; break;
                case 6: button86.BackColor = Color.Gold; break;
                case 7: button87.BackColor = Color.Gold; break;
                case 8: button88.BackColor = Color.Gold; break;
                case 9: button89.BackColor = Color.Gold; break;
                case 10: button93.BackColor = Color.Gold; break;
            }
        }

        void reset_val()
        {
            switch (v)
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
                case 10: button93.BackColor = Color.MediumSeaGreen; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta valoare a fost deja introdusa!");
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
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button1.Text = n.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button3.Text = n.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button18.Text = n.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button17.Text = n.ToString();
            }
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
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button16.Text = n.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button27.Text = n.ToString();
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
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button26.Text = n.ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button25.Text = n.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button6.Text = n.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button5.Text = n.ToString();
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
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button4.Text = n.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button14.Text = n.ToString();
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

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button23.Text = n.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button9.Text = n.ToString();
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
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button12.Text = n.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button10.Text = n.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button21.Text = n.ToString();
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
                n = 2;
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
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button19.Text = n.ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button36.Text = n.ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button35.Text = n.ToString();
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
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button34.Text = n.ToString();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button45.Text = n.ToString();
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

        private void button54_Click(object sender, EventArgs e)
        {
            if (button54.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button54.Text = n.ToString();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (button53.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button53.Text = n.ToString();
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
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button33.Text = n.ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button31.Text = n.ToString();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button42.Text = n.ToString();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button40.Text = n.ToString();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (button51.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button51.Text = n.ToString();
            }
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
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button49.Text = n.ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button29.Text = n.ToString();
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
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button28.Text = n.ToString();
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
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button38.Text = n.ToString();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button37.Text = n.ToString();
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
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button48.Text = n.ToString();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button47.Text = n.ToString();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button46.Text = n.ToString();
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
                n = 2;
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
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button62.Text = n.ToString();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (button61.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 9;
                verificare_valoare();
                if (ok == true)
                    button61.Text = n.ToString();
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (button72.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button72.Text = n.ToString();
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
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button70.Text = n.ToString();
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (button79.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button79.Text = n.ToString();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (button59.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 4;
                verificare_valoare();
                if (ok == true)
                    button59.Text = n.ToString();
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
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button69.Text = n.ToString();
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (button68.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button68.Text = n.ToString();
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
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button78.Text = n.ToString();
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (button77.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button77.Text = n.ToString();
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (button76.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button76.Text = n.ToString();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (button57.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 7;
                verificare_valoare();
                if (ok == true)
                    button57.Text = n.ToString();
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
                n = 3;
                verificare_valoare();
                if (ok == true)
                    button56.Text = n.ToString();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (button55.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 1;
                verificare_valoare();
                if (ok == true)
                    button55.Text = n.ToString();
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
                n = 8;
                verificare_valoare();
                if (ok == true)
                    button66.Text = n.ToString();
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (button65.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 5;
                verificare_valoare();
                if (ok == true)
                    button65.Text = n.ToString();
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (button64.Text != "")
            {
                MessageBox.Show("Aceasta valoare a fost deja introdusa!");
            }
            else
            {
                ok = false;
                n = 2;
                verificare_valoare();
                if (ok == true)
                    button64.Text = n.ToString();
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
                n = 6;
                verificare_valoare();
                if (ok == true)
                    button75.Text = n.ToString();
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

        private void button90_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 1;
            val_selectata();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            reset_val();
            v = 2;
            val_selectata();
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

        private void button92_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.instance.Show();

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
        }

        private void button94_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
