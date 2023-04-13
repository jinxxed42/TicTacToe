using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class FieldStatus
    {
        public string Owner { get; set; }
        public string Name { get; set; }

        public FieldStatus(string name) 
        {
            Owner = "";
            Name = name;
        }
    }
}
