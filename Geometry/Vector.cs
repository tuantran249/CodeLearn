namespace Geometry
{
    public class Vector
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Vector(Point pointX, Point pointY)
        {
            X = pointY.XPosition - pointX.XPosition;
            Y = pointY.YPosition - pointX.YPosition;
        }
    }
}
