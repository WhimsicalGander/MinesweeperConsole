namespace MinesweeperConsole
{
    using MinesweeperLibrary;
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minesweeper! What difficulty would you like to play? 1, 2, or 3?");
            int difficulty = int.Parse(Console.ReadLine());

            DateTime start = DateTime.Now;

            Board board = new Board(12, start, difficulty);

            string [] printableBoard = board.makePrintable();

            for (int i = 0; i < printableBoard.Length; i++)
            {
                Console.WriteLine(printableBoard[i]);
            }

            Console.WriteLine("And Here is the second game answer!");

            DateTime start2 = DateTime.Now;

            Board board2 = new Board(8, start2, difficulty);

            string[] printableBoard2 = board2.makePrintable();

            for (int i = 0; i < printableBoard2.Length; i++)
            {
                Console.WriteLine(printableBoard2[i]);
            }

        }



    }
}
