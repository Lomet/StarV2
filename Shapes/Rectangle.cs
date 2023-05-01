using System.Drawing;
using StarV2;

public class Rectangle : IShape
{
    public Rectangle(int width, int height)
    {
        var Checks = new List<PixelCheck>
        {
            PixelCheck.XLine(0), // Top line
            PixelCheck.XLine(height - 1), // Bottom line
            PixelCheck.YLine(0), // Left line
            PixelCheck.YLine(width - 1) // Right line
        };

        Board = new PixelBoard(Checks, new Point(height, width));
    }

    public PixelBoard Board { get; }
}
