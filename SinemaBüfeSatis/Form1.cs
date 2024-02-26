namespace SinemaBüfeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, cay, toplam;
            mısır = Convert.ToInt16(TxtMısır.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = mısır * 10 + bilet * 20 + cay * 5 + su * 3;
            LblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = " ";
            TxtCay.Text = " ";
            TxtMısır.Text = " ";
            TxtSu.Text = " ";
            TxtMısır.Focus();
        }
    }
}
