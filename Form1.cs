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


        // Change names of boxes to 0 - 8
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            if (g.FieldStates[0].Owner != "")
            {
                Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                pictureBox0.Image = image;
                g.FieldStates[0].Owner = "";
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                pictureBox0.Image = image;
                g.FieldStates[0].Owner = "Cross";
                g.CheckWinner();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox1.Image = image;
            g.FieldStates[1].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox2.Image = image;
            g.FieldStates[2].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox3.Image = image;
            g.FieldStates[3].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox4.Image = image;
            g.FieldStates[4].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox5.Image = image;
            g.FieldStates[5].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox6.Image = image;
            g.FieldStates[6].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox7.Image = image;
            g.FieldStates[7].Owner = "Cross";
            g.CheckWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
            pictureBox8.Image = image;
            g.FieldStates[8].Owner = "Cross";
            g.CheckWinner();
        }
    }
}