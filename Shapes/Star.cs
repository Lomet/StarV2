using System.Drawing;
using StarV2;

public class Star : IShape
{
    public Star(int N = 18)
    {
        int Q1 = N / 4 + N % 2;
        int Long_line = N * 2 - 1;
        int Tall_line = N + Q1;

        var Checks = new List<PixelCheck>
        {
            PixelCheck.XLine(Q1), // Top long line
            PixelCheck.XLine(Tall_line - Q1 - 1),  // Bottom long line
            PixelCheck.XplusYLine(N - 1), // Left '/'
            PixelCheck.XplusYLine(Q1 + Long_line - 1), // Right '/'
            PixelCheck.XminusYLine(1 - N), // Right '\'
            PixelCheck.XminusYLine(Q1)// Left '\'
        };

        Board = new PixelBoard(Checks, new Point(Tall_line, Long_line));
    }
    public PixelBoard Board { get;}
}