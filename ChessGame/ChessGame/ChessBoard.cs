using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    internal class ChessBoard
    {

        public Dictionary<string, Figure> chessBoard;


        public ChessBoard()
        {
            chessBoard = new Dictionary<string, Figure>
            {
                { "A1" , new Rook("Black", "A1")},
                { "A2" , new Knight("Black", "A2")},
                { "A3" , new Bishop("Black", "A3")},
                { "A4" , new Queen("Black", "A4")},
                { "A5" , new King("Black", "A5")},
                { "A6" , new Bishop("Black", "A6")},
                { "A7" , new Knight("Black", "A7")},
                { "A8" , new Rook("Black", "A8")},
                { "B1" , new Pawn("Black", "B1")},
                { "B2" , new Pawn("Black", "B2")},
                { "B3" , new Pawn("Black", "B3")},
                { "B4" , new Pawn("Black", "B4")},
                { "B5" , new Pawn("Black", "B5")},
                { "B6" , new Pawn("Black", "B6")},
                { "B7" , new Pawn("Black", "B7")},
                { "B8" , new Pawn("Black", "B8")},
                { "C1" , null},
                { "C2" , null},
                { "C3" , null},
                { "C4" , null},
                { "C5" , null},
                { "C6" , null},
                { "C7" , null},
                { "C8" , null},
                { "D1" , null},
                { "D2" , null},
                { "D3" , null},
                { "D4" , null},
                { "D5" , null},
                { "D6" , null},
                { "D7" , null},
                { "D8" , null},
                { "E1" , null},
                { "E2" , null},
                { "E3" , null},
                { "E4" , null},
                { "E5" , null},
                { "E6" , null},
                { "E7" , null},
                { "E8" , null},
                { "F1" , null},
                { "F2" , null},
                { "F3" , null},
                { "F4" , null},
                { "F5" , null},
                { "F6" , null},
                { "F7" , null},
                { "F8" , null},
                { "G1" , new Pawn("White", "G1")},
                { "G2" , new Pawn("White", "G2")},
                { "G3" , new Pawn("White", "G3")},
                { "G4" , new Pawn("White", "G4")},
                { "G5" , new Pawn("White", "G5")},
                { "G6" , new Pawn("White", "G6")},
                { "G7" , new Pawn("White", "G7")},
                { "G8" , new Pawn("White", "G8")},
                { "H1" , new Rook("White", "H1")},
                { "H2" , new Knight("White", "H2")},
                { "H3" , new Bishop("White", "H3")},
                { "H4" , new Queen("White", "H4")},
                { "H5" , new King("White", "H5")},
                { "H6" , new Bishop("White", "H6")},
                { "H7" , new Knight("White", "H7")},
                { "H8" , new Rook("White", "H8")},
            };
        }

        public void PrintBoard()
        {            
            Console.Clear();
            string line = "";
            byte count = 0;
            foreach (string pos in chessBoard.Keys)
            {
                count += 1;
                if (chessBoard[pos] != null)
                { 
                    line +=  " " + chessBoard[pos].PrintIcon() + " ";
                }
                else
                {
                    line += pos + " ";
                }
                
                if (count == 8)
                {
                    count = 0;
                    Console.WriteLine(line);
                    line = "";
                }
            }
        }

/*
        public void selectPosition()
        {
            Console.WriteLine("select position of the figure you want to move");
            string figurePosition = Console.ReadLine();
            Console.WriteLine("Select a position for the figure");
            string newPosition = Console.ReadLine();
        }

        public void selectFigure()
        {
            Console.WriteLine("Select Firgure you want to move");
            string slectedFigure = Console.ReadLine();
        }   
*/     
    }
}
