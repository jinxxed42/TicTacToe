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
            string winner = "";

            for (int i = 0; i < FieldStates.Count; i +=3 )
            {
                if (FieldStates[i].Owner != "" && FieldStates[i].Owner == FieldStates[i+1].Owner && FieldStates[i+1].Owner == FieldStates[i+2].Owner)
                {
                    winner = FieldStates[i].Owner;
                    break;
                }
            }
            if (winner == "")
            {
                for (int i = 0; i < 3; i++)
                {
                    if (FieldStates[i].Owner != "" && FieldStates[i].Owner == FieldStates[i+3].Owner && FieldStates[i+3].Owner == FieldStates[i+6].Owner)
                    {
                        winner = FieldStates[i].Owner;
                        break;
                    }
                }
            }

            if (winner == "" && FieldStates[0].Owner != "" && FieldStates[0].Owner == FieldStates[4].Owner && FieldStates[4].Owner == FieldStates[8].Owner)
            {
                winner = FieldStates[0].Owner;
            }
            if (winner == "" && FieldStates[6].Owner != "" && FieldStates[6].Owner == FieldStates[4].Owner && FieldStates[4].Owner == FieldStates[2].Owner)
            {
                winner = FieldStates[6].Owner;
            }

            if (winner != "")
            {
                MessageBox.Show("The winner is " + winner + "!");
            }
        }
    }
}
