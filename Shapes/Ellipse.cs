using System.Drawing;
using StarV2;

public class Ellipse : IShape
{
    public Ellipse(int x, int y)
    {
        Middle = new Point(x, y);
        Board = CreateEllipseBoard(Middle);
    }
    public Ellipse(Point middle)
    {
        Middle = middle;
        Board = CreateEllipseBoard(middle);
    }

    public PixelBoard Board { get; }
    private Point Middle { get; }

    private PixelBoard CreateEllipseBoard(Point middle)
    {
        var Checks = new List<PixelCheck>
        {
            new PixelCheck(point => IsPointInEllipse(point))
        };

        return new PixelBoard(Checks, new Point(middle.X * 2 + 1, middle.Y * 2 + 1));
    }

    private bool IsPointInEllipse(Point point)
    {
        int dx = point.X - Middle.X;
        int dy = point.Y - Middle.Y;
        double distanceSquared = (double)dx * dx / (Middle.X * Middle.X) + (double)dy * dy / (Middle.Y * Middle.Y);

        return distanceSquared <= 1;
    }
}
