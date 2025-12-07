using System.Text;
namespace ChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            ChessBoard gameManager = new ChessBoard();
            gameManager.PrintBoard();
            Console.WriteLine("Choose your piece");
            string figurePosition = Console.ReadLine();
            Console.WriteLine("Move your piece");
            string newPosition = Console.ReadLine();
            if (gameManager.chessBoard[figurePosition].ValidateMove(newPosition))
            {
                gameManager.chessBoard[figurePosition].Move(newPosition);
            }
            else
            {
                Console.WriteLine("Class Error!!!");
            }
            gameManager.PrintBoard();

        }
    }
}
