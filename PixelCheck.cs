using System.Drawing;

namespace StarV2;

public class PixelCheck
{
    public delegate bool Check(Point point);
    private Check GetAction { get; }
    public PixelCheck(Check action)
    {
        GetAction = action;
    }
    public bool GetPixel(Point point) => GetAction.Invoke(point);
    public static PixelCheck XLine(int line) => new PixelCheck(Point => Point.X == line);
    public static PixelCheck YLine(int line) => new PixelCheck(Point => Point.Y == line);
    public static PixelCheck XplusYLine(int line) => new PixelCheck(Point => Point.X + Point.Y == line);
    public static PixelCheck XminusYLine(int line) => new PixelCheck(Point => Point.X - Point.Y == line);
}
