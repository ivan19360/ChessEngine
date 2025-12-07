using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
internal class Rook : Figure
{
    public Rook(string team, string startPosition)
    {
        this.team = team;
        this.position = startPosition;
        if (this.team.ToLower() == "white")
        {
            icon = "♖";
        }
        else
        {
            icon = "♜";
        }
    }

    public override bool ValidateMove(string newPosition)
    {
        return true;
    }

    }
}
