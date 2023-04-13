using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public List<FieldStatus> FieldStates = new List<FieldStatus>();

        public Game()
        {
            for (int i = 1; i < 10; i++)
            {
                FieldStatus f = new FieldStatus($"Field{i}");
                FieldStates.Add(f);
            }

        }

        public void CheckWinner()
        {
            // Need smarter way of doing this.
            if (FieldStates[0].Owner != "" && FieldStates[0].Owner == FieldStates[1].Owner && FieldStates[1].Owner == FieldStates[2].Owner)
            {
                MessageBox.Show("WE HAVE A WINNER!");
            }
        }
    }
}
