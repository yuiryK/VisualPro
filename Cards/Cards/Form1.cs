namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Eight of Diamonds";
        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Three of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "King of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Ace of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "Joke of Black";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}