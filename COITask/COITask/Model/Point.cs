using System;

namespace COITask
{
    /// <summary>
    /// Basic point node for container purposes
    /// </summary>
    /// <typeparam name="T">supports numerical values</typeparam>
    public abstract class Point<T> where T : struct,
                                    IComparable,
                                    IComparable<T>
    {
        public abstract void Print();
    }

    /// <summary>
    /// Definition of 1-dimensional point
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point1D<T> : Point<T> where T : struct,
                                                 IComparable,
                                                 IComparable<T>
    {
        public readonly T X;

        public Point1D()
        {
        }

        public Point1D(T x)
        {
            X = x;
        }

        public override void Print()
        {
            Console.Write("Point "+X);
        }
    }

    /// <summary>
    /// Definition of 2-dimensional point
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point2D<T> : Point<T> where T : struct,
                                                 IComparable,
                                                 IComparable<T>
    {
        public readonly T X;
        public readonly T Y;

        public Point2D()
        {
        }

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public override void Print()
        {
            Console.Write("Point " + $"{X},{Y}");
        }
    }

    /// <summary>
    /// Definition of 3 -dimensional point
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point3D<T> : Point<T> where T : struct,
                                                 IComparable,
                                                 IComparable<T>
    {
        public readonly T X;
        public readonly T Y;
        public readonly T Z;

        public Point3D()
        {
        }

        public Point3D(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override void Print()
        {
            Console.Write("Point " + $"{X},{Y},{Z}");
        }
    }
}
