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
            for (int i = 0; i < 9; i++)
            {
                FieldStatus f = new FieldStatus($"Field{i}");
                FieldStates.Add(f);
            }

        }

        public CheckWinner()
        {

        }

    }
}
