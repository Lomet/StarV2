using System.Drawing;

namespace StarV2
{
    public class PixelBoard
    {
        private char One { get; }
        private char Zero { get; }
        public PixelBoard(List<PixelCheck> pixelChecks, Point size, char one = '*', char zero = ' ')
        {
            One = one;
            Zero = zero;
            PixelChecksList = pixelChecks;
            Size = size;
        }
        private List<PixelCheck> PixelChecksList { get; }
        public Point Size { get; private set; } //Max point, first point is 0,0
        public void DrawBoard()
        {
            for (int i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    var this_point = new Point(i, j);
                    Console.Write(PixelChecksList.Any(T => T.GetPixel(this_point)) ? One : Zero);
                }
                Console.WriteLine();
            }
        }
    }
}
