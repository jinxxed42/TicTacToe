namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Game g;

        public Form1()
        {
            InitializeComponent();
            g = new Game();
            lblCurrentTurnText.Text = g.Turn;
        }


        // Change names of boxes to 0 - 8
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[0].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox0.Image = image;
                        g.FieldStates[0].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox0.Image = image;
                    g.FieldStates[0].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[0].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox0.Image = image;
                        g.FieldStates[0].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox0.Image = image;
                    g.FieldStates[0].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[1].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox1.Image = image;
                        g.FieldStates[1].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox1.Image = image;
                    g.FieldStates[1].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[1].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox1.Image = image;
                        g.FieldStates[1].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox1.Image = image;
                    g.FieldStates[1].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[2].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox2.Image = image;
                        g.FieldStates[2].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox2.Image = image;
                    g.FieldStates[2].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[2].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox2.Image = image;
                        g.FieldStates[2].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox2.Image = image;
                    g.FieldStates[2].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[3].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox3.Image = image;
                        g.FieldStates[3].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox3.Image = image;
                    g.FieldStates[3].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[3].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox3.Image = image;
                        g.FieldStates[3].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox3.Image = image;
                    g.FieldStates[3].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[4].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox4.Image = image;
                        g.FieldStates[4].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox4.Image = image;
                    g.FieldStates[4].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[4].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox4.Image = image;
                        g.FieldStates[4].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox4.Image = image;
                    g.FieldStates[4].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[5].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox5.Image = image;
                        g.FieldStates[5].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox5.Image = image;
                    g.FieldStates[5].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[5].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox5.Image = image;
                        g.FieldStates[5].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox5.Image = image;
                    g.FieldStates[5].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[6].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox6.Image = image;
                        g.FieldStates[6].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox6.Image = image;
                    g.FieldStates[6].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[6].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox6.Image = image;
                        g.FieldStates[6].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox6.Image = image;
                    g.FieldStates[6].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[7].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox7.Image = image;
                        g.FieldStates[7].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox7.Image = image;
                    g.FieldStates[7].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[7].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox7.Image = image;
                        g.FieldStates[7].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox7.Image = image;
                    g.FieldStates[7].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (g.Turn == "Cross")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Cross").Count == 3)
                {
                    if (g.FieldStates[8].Owner == "Cross")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox8.Image = image;
                        g.FieldStates[8].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Cross.png");
                    pictureBox8.Image = image;
                    g.FieldStates[8].Owner = "Cross";
                    g.CheckWinner();
                    g.Turn = "Circle";
                    lblCurrentTurnText.Text = "Circle";
                }
            }
            else if (g.Turn == "Circle")
            {
                if (g.FieldStates.FindAll(o => o.Owner == "Circle").Count == 3)
                {
                    if (g.FieldStates[8].Owner == "Circle")
                    {
                        Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Empty.png");
                        pictureBox8.Image = image;
                        g.FieldStates[8].Owner = "";
                    }
                    else
                    {
                        MessageBox.Show("Need to deselect an owned tile first.");
                    }
                }
                else
                {
                    Image image = Image.FromFile(@"C:\Users\claus\source\repos\TicTacToe\Circle.png");
                    pictureBox8.Image = image;
                    g.FieldStates[8].Owner = "Circle";
                    g.CheckWinner();
                    g.Turn = "Cross";
                    lblCurrentTurnText.Text = "Cross";
                }
            }
        }
    }
}