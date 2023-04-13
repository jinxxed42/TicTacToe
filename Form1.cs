namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Game g;

        public Form1()
        {
            InitializeComponent();
            g = new Game();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (g.FieldStates[0].Owner != "")
            {
                Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                pictureBox1.Image = image;
                g.FieldStates[0].Owner = "";
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                pictureBox1.Image = image;
                g.FieldStates[0].Owner = "Cross";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox2.Image = image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox3.Image = image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox4.Image = image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox5.Image = image;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox6.Image = image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox7.Image = image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox8.Image = image;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox9.Image = image;
        }
    }
}