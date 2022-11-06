namespace XO
{
    public partial class Form1 : Form
    {
        public int brojac { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Odigraj(object sender)
        {
            if (sender is Button)
            {

                var button = sender as Button;
                if (button.Text == "")
                {
                    if (brojac % 2 == 0)
                        button.Text = "X";
                    else
                        button.Text = "O";
                    brojac++;
                    if (KrajIgre())
                    {
                        IskljuciKontroleDugmica(false);
                    }
                }
            }
        }

        private void IskljuciKontroleDugmica(bool enabled)
        {
            foreach (var kontrola in this.Controls)
            {
                if (kontrola is Button)
                {
                    if(kontrola != btnNewGame)
                    (kontrola as Button).Enabled = enabled;
                }
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDiagonale();
        }

        private bool ProvjeriDiagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                    ProvjeriPobjedu(button2, button5, button8) ||
                    ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                ProvjeriPobjedu(button4, button5, button6) ||
                ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button btn1, Button btn2, Button btn3)
        {
            var isti = btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text; ;
            if (isti)
            {
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.Coral;
            }
            return isti;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odigraj(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Odigraj(sender);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            NovaIgra();
        }

        private void NovaIgra()
        {
            IskljuciKontroleDugmica(true);
            PostaviNaPocetak();
            }

        private void PostaviNaPocetak()
        {
            foreach (var item in Controls)
            {
                var btn = item as Button;
                if(btn != btnNewGame)
                {
                    btn.Text = "";
                    brojac = 0;
                    btn.UseVisualStyleBackColor = true;

                }
            }
        }
    }
    }
