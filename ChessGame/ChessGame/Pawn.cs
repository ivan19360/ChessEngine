using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    internal class Pawn : Figure
    {
        public Pawn(string team, string startPosition)
        {
            this.team = team;
            this.position = startPosition;
            AssignIcon();
        }

        private void AssignIcon()
        {
            if (team.ToLower() == "white")
            {
                icon = "♙";
            }
            else
            {
                icon = "♟";
            }
        }

        public override bool ValidateMove(string newPosition)
        {
            return true;
        }
    }
 }

