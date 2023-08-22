using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;

namespace RPSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();

        }
    }
}