using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public abstract class Figure
    {
        protected string team;
        protected string position;
        protected bool firstTurn = true;
        protected string icon;
        public abstract bool ValidateMove(string newPosition);

        public void Move(string newPosition)
        {
            position = newPosition;
        }

        public string GetPosition()
        {
            return position;
        }

        public string PrintIcon()
        {
            return icon;
        }
    }
}
