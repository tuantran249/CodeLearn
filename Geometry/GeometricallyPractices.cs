using System.Collections.Generic;

namespace Geometry
{
    public class GeometricallyPractices
    {
        /// Given a set of points, find the number of triangles with non-zero areas formed by some trio of the given points.
        /// https://codelearn.io/learning/thuat-toan-can-ban/3789
        public static int CountTriangles(int[] x, int[] y)
        {
            var listPoint = new List<Point>();
            for (int i = 0; i < x.Length; i++)
            {
                listPoint.Add(new Point(x[i], y[i]));
            }
            int numberOfTriangles = 0;
            for (int i = 0; i < listPoint.Count; i++)
            {
                for (int k = i + 1; k < listPoint.Count; k++)
                {
                    for (int l = k + 1; l < listPoint.Count; l++)
                    {
                        if (isCollinear(new Vector(listPoint[i], listPoint[k]), new Vector(listPoint[k], listPoint[l])))
                        {
                            numberOfTriangles++;
                        }
                    }
                }
            }

            return numberOfTriangles;
        }
        public static bool isCollinear(Vector vectorU, Vector vectorV)
        {
            return vectorU.X * vectorV.Y == vectorU.Y * vectorV.X;
        }

        /// You have four points in an array points = [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]. 
        /// You make a (possibly self-intersecting) 4-sided polygon by joining the adjacent points 
        /// in the list and joining points[3] back to points[0]. 
        /// Write a function that returns true if the shape formed by points is a rectangle, and false otherwise.
        /// https://codelearn.io/learning/thuat-toan-can-ban/3908
        public static bool IsRectangle(int[][] points)
        {
            var pointA = new Point(points[0][0], points[0][1]);
            var pointB = new Point(points[1][0], points[1][1]);
            var pointC = new Point(points[2][0], points[2][1]);
            var pointD = new Point(points[3][0], points[3][1]);

            var vectorAB = new Vector(pointA, pointB);
            var vectorBC = new Vector(pointB, pointC);
            var vectorCD = new Vector(pointC, pointD);
            var vectorDA = new Vector(pointD, pointA);

            return isPerpen(vectorAB, vectorBC) &&
            isPerpen(vectorBC, vectorCD) &&
            isPerpen(vectorCD, vectorDA);
        }

        private static bool isPerpen(Vector vectorU, Vector vectorV)
        {
            return vectorU.X * vectorV.X + vectorU.Y * vectorV.Y == 0;
        }
    }

}